using System;
using OpenRasta.DI;
using OpenRasta.Configuration;
using OpenRasta.Hosting.HttpListener;

namespace Workbench.Resources
{
    public class HttpServer
    {
        private readonly Action _configuration;
        private HttpServerHost _server;

        public HttpServer(Action configuration)
        {
            _configuration = configuration;
        }

        public void Start()
        {
            _server = new HttpServerHost(_configuration);
            _server.Initialize(new[] {string.Format(ServerData.Prefix, "+", ServerData.Port)}, "/", null);
            _server.StartListening();
        }
        public void Stop()
        {
            _server.StopListening();
            _server.Close();
        }
        class HttpServerHost : HttpListenerHost, IConfigurationSource
        {
            private readonly Action _configuration;

            public HttpServerHost(Action configuration)
            {
                _configuration = configuration;
            }

            public override bool ConfigureRootDependencies(OpenRasta.DI.IDependencyResolver resolver)
            {
                resolver.AddDependencyInstance<IConfigurationSource>(this);
                return base.ConfigureRootDependencies(resolver);
            }

            public void Configure()
            {
                using (OpenRastaConfiguration.Manual)
                {
                    _configuration();
                }
            }
        }
    }
}