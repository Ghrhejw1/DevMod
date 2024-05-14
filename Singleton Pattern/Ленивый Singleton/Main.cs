using SingletonPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Servers.Instance.AddServer("https://translate.yandex.ru/");
        Servers.Instance.AddServer("http://leetcode.com/problemset/all/");
        Servers.Instance.AddServer("https://biblioclub.ru/"); 
        Servers.Instance.AddServer("http://colorscheme.ru/html-colors.html"); 

        List<string> httpServers = Servers.Instance.GetHTTPServers();
        Console.WriteLine("HTTP сервера:");
        foreach (string server in httpServers)
        {
            Console.WriteLine(server);
        }

        List<string> httpsServers = Servers.Instance.GetHTTPSServers();
        Console.WriteLine("\n HTTPS сервера:");
        foreach (string server in httpsServers)
        {
            Console.WriteLine(server);
        }
    }
}
