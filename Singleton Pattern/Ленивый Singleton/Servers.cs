using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Servers
    {
        private static readonly Lazy<Servers> lazyInstance = new Lazy<Servers>(() => new Servers());

        private List<string> serverList = new List<string>();

        private Servers()
        {
        }

        public static Servers Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        public bool AddServer(string server)
        {
            
            if (server.StartsWith("http://") || server.StartsWith("https://"))
            {
                
                if (!serverList.Contains(server))
                {
                    serverList.Add(server);
                    return true; 
                }
            }
            return false; 
        }

        
        public List<string> GetHTTPServers()
        {
            List<string> httpServers = new List<string>();
            foreach (string server in serverList)
            {
                if (server.StartsWith("http://"))
                {
                    httpServers.Add(server);
                }
            }
            return httpServers;
        }
        
        public List<string> GetHTTPSServers()
        {
            List<string> httpsServers = new List<string>();
            foreach (string server in serverList)
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
