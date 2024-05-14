using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Servers
    {
        private static Servers instance = new Servers();

        private List<string> serversList = new List<string>();

        private static readonly object lockObject = new object();

        private Servers()
        {
        }

        public static Servers Instance
        {
            get
            {
                return instance;
            }
        }

        public bool AddServer(string server)
        {
            if (server.StartsWith("http://") || server.StartsWith("https://"))
            {
                lock(lockObject)
                {
                    if(!serversList.Contains(server))
                    {
                        serversList.Add(server);
                        return true;
                    }
                }
            }
            return false;
        }

        public List<string> GetHTTPServers()
        {
            List<string> httpsServers = new List<string>();

            foreach (string server in serversList)
            {
                if (server.StartsWith("http://"))
                {
                    httpsServers.Add(server);
                }
            }
            return httpsServers;
        }
        public List<string> GetHTTPSServers()
        {
            List<string> httpsServers = new List<string>();
            foreach (string server in serversList)
            {
                if (server.StartsWith("https://"))
                {
                    httpsServers.Add(server);
                }
            }
            return httpsServers;
        }
    }
}
