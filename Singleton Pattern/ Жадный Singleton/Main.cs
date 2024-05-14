namespace SingletonPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Servers.Instance.AddServer("http://www.google.com");
            Servers.Instance.AddServer("http://www.yandex.com");
            Servers.Instance.AddServer("https://www.git.com");
            Servers.Instance.AddServer("https://www.vk.com");
            Servers.Instance.AddServer("http://www.example.com");

            List<string> httpServers = Servers.Instance.GetHTTPServers();
            Console.WriteLine("HTTP сервера:");
            foreach (string server in httpServers)
            {
                Console.WriteLine(server);
            }

            List<string> httpsServers = Servers.Instance.GetHTTPSServers();
            Console.WriteLine("HTTPS сервера:");
            foreach (string server in httpsServers)
            {
                Console.WriteLine(server);
            }
        }
    }
}
