using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workbench
{
    class ServerData
    {
        public static string ResponseCacheControl = "public; max-age=5";
        public static int Port = 57100;
        public static bool RequestUseSystemProxy;
        public static event Action<string> Log;

        public static Func<DateTime?> ResponseLastModified = () => DateTime.UtcNow;
        public static string Prefix = "http://{0}:{1}/";

        public static void LogMessage(string value)
        {
            var log = Log;
            if (log != null)
                log(value);
        }
    }
}
