using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //netsh http add urlacl url=http://localhost:4545/ user=ArashKaf   مجوز دسترسی به پورت

            var config = new HttpSelfHostConfiguration("http://localhost:5001");
            config.Routes.MapHttpRoute
            (
                "Default", "api/{controller}/{id}", new { id = RouteParameter.Optional }
            );
            HttpSelfHostServer server = new HttpSelfHostServer(config);
            server.OpenAsync().Wait();
            Console.ReadLine();
        }
    }
}
