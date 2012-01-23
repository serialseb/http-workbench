using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using OpenRasta.Configuration;
using OpenRasta.Pipeline;
using OpenRasta.Web;
using Workbench.Resources;

namespace Workbench
{
    public partial class MainForm : Form
    {
        private HttpServer _server;

        static IDictionary<string, Func<HttpWebRequest, Action<string>>> _maps = new Dictionary<string, Func<HttpWebRequest, Action<string>>>(StringComparer.OrdinalIgnoreCase)
        {
            {"Accept", request => input => request.Accept = input },
            {"Content-Length", request => input => request.ContentLength = long.Parse(input) },
            {"Content-Type", request => input => request.ContentType = input },
            {"If-Modified-Since", request=>input=>request.IfModifiedSince = DateTime.Parse(input)},
            {"User-Agent", request=>input=>request.UserAgent = input}
        };
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            responseCacheControl.Text = ServerData.ResponseCacheControl;
            ServerData.Log += LogLine;
            responseCacheControl.TextChanged += (s, ea) =>
                ServerData.ResponseCacheControl = responseCacheControl.Text;
            requestCachePolicy.Items.AddRange(Enum.GetNames(typeof(RequestCacheLevel)));
            requestCachePolicy.SelectedIndex = 0;
            clearButton.Click += (s, ea) =>
            {
                clientLog.Clear();
                responseLog.Clear();
            };
            responseLastModified.TextChanged += (s, ea) =>
            {
                Func<DateTime?> lastModified = ()=>null;
                DateTime lastModifiedValue;
                if (responseLastModified.Text == "(Now)")
                    lastModified  = ()=> DateTime.UtcNow;
                else if (DateTime.TryParse(responseLastModified.Text, out lastModifiedValue))
                    lastModified = ()=> lastModifiedValue;

                ServerData.ResponseLastModified = lastModified;
            };
            requestSystemProxy.CheckedChanged +=
                (s, ea) => ServerData.RequestUseSystemProxy = requestSystemProxy.Checked;
            TextBoxTraceListener.SetControl(clientLog);
            serverPort.Text = ServerData.Port.ToString();
            serverPort.TextChanged += (s, ea) => ServerData.Port = int.Parse(serverPort.Text);
            serverPrefix.Text = ServerData.Prefix;
            serverPrefix.TextChanged += (s, ea) => ServerData.Prefix = serverPrefix.Text;
            
            _server = new HttpServer(() =>
                                         {
                                             ResourceSpace.Uses.PipelineContributor<DumpRequest>();
                                             ResourceSpace.Has.ResourcesOfType<Document>()
                                                 .AtUri("/{id}")
                                                 .HandledBy<DocumentHandler>()
                                                 .AsJsonDataContract();
                                         });
            _server.Start();
            restartButton.Click += (s, ea) =>
                                       {
                                           _server.Stop();
                                           _server.Start();
                                       };
        }
        void LogLine(string line)
        {
            responseLog.BeginInvoke((Action)(() =>
            {
                responseLog.Text += line + "\r\n";
                responseLog.SelectionStart = responseLog.Text.Length;
                responseLog.ScrollToCaret();
            }));

        }
        private void sendRequest_Click(object sender, EventArgs e)
        {
            var requestMethod = method.Text;
            var allRequestLines = request.Text.Split(new[] { "\r\n" }, StringSplitOptions.None);
            var cacheLevel = (RequestCacheLevel)Enum.Parse(typeof(RequestCacheLevel), requestCachePolicy.Text);
            var machineName = requestUseMachineName.Checked ? Environment.MachineName : "localhost";
            ThreadPool.QueueUserWorkItem(state =>
            {
                var defaultUri = new Uri(string.Format(ServerData.Prefix, machineName, ServerData.Port));
                var userUri = new Uri(uri.Text, UriKind.RelativeOrAbsolute);
                var targetUri = new Uri(defaultUri, userUri);
                var client = (HttpWebRequest)WebRequest.Create(targetUri);
                client.Proxy = ServerData.RequestUseSystemProxy ? GetProxy(targetUri) : null;

                client.CachePolicy = new RequestCachePolicy(cacheLevel);
                client.Method = requestMethod;
                

                
                foreach (var line in allRequestLines.TakeWhile(x => x != "")
                    .Concat(new[]{"Accept: */*"}))
                {
                    var name = line.Substring(0, line.IndexOf(":"));
                    var value = line.Substring(line.IndexOf(":") + 1);
                    if (_maps.ContainsKey(name))
                        _maps[name](client)(value);
                    else
                        client.Headers[name] = value;
                }

                // upload not set yet
                //foreach(var line in allRequestLines.SkipWhile(x=>x != "").Skip(1))
                //    client.
                Response response = null;
                try
                {
                    response = PopulateResponseFromWebResponse((HttpWebResponse) client.GetResponse());
                }
                catch(WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.CacheEntryNotFound)
                        response = new Response { StatusCode = 504, StatusDescription = "Timeout: Cache entry not found" };
                    else if (ex.Response != null)
                        response = PopulateResponseFromWebResponse((HttpWebResponse)ex.Response);
                    else
                        response = new Response
                                       {
                                           StatusCode = (int) ex.Status,
                                           StatusDescription = ex.Status.ToString(),
                                           Stream = new MemoryStream(Encoding.UTF8.GetBytes(ex.Message))
                                       };
                }
               
                WriteResponse(response);
                LogLine("---------------------------------");
                LogLine("");

            });
        }

        private void WriteResponse(Response response)
        {
            LogLine("< " + response.StatusCode + " " + response.StatusDescription);
                    
                    
            foreach (var header in response.Headers)
                LogLine("< " + header.Key + ": " + header.Value);
            LogLine("< ");
            if (response.Stream != null)
                using (var reader = new StreamReader(response.Stream))
                 while (!reader.EndOfStream)
                     LogLine("< " + reader.ReadLine());
        }

        private Response PopulateResponseFromWebResponse(HttpWebResponse client)
        {
            return new Response
                       {
                           Stream = client.ContentLength > 0 ? client.GetResponseStream() : null,
                           StatusCode = (int) client.StatusCode,
                           StatusDescription = client.StatusDescription,
                           Headers = client.Headers.AllKeys.ToDictionary(_ => _, _ => client.Headers[_],
                                                                         StringComparer.OrdinalIgnoreCase)
                       };
        }

        IWebProxy GetProxy(Uri uri)
        {
            return new WebProxy(WebRequest.GetSystemWebProxy().GetProxy(uri), false);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    public class DumpRequest : IPipelineContributor
    {
        public void Initialize(IPipeline pipelineRunner)
        {
            pipelineRunner.Notify(DumpRequestToWindow)
                .Before<KnownStages.IRequestDecoding>();
        }

        private PipelineContinuation DumpRequestToWindow(ICommunicationContext arg)
        {
            ServerData.LogMessage(string.Format("> {0} {1}", arg.Request.HttpMethod, arg.Request.Uri));

            foreach(var kv in arg.Request.Headers)
                ServerData.LogMessage("> " + kv.Key + ": " + kv.Value);
            ServerData.LogMessage(">");
            return PipelineContinuation.Continue;

        }
    }

    public class Response
    {
        public Response()
        {
            Headers = new Dictionary<string, string>();

        }
        public Stream Stream { get; set; }
        public int StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public IDictionary<string, string> Headers { get; set; }
    }

    internal class DocumentHandler
    {
        private IResponse _response;

        public DocumentHandler(IResponse response)
        {
            _response = response;
        }

        public Document Get(int id)
        {
            ServerData.LogMessage("Processing request from handler.");
            var doc = new Document();
            var lastModified = ServerData.ResponseLastModified();
            if (lastModified != null)
            {
                _response.Headers["Last-Modified"] = lastModified.Value.ToString("ddd, dd MMM yyyy HH:mm:ss K");
                doc.LastModified = lastModified;
            }

            _response.Headers["Cache-Control"] = ServerData.ResponseCacheControl;
            return new Document();
        }
    }

    public class Document
    {
        public Document()
        {
        }

        public DateTime? LastModified { get; set; }
    }
}
