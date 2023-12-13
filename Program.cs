using System;

using System.Web.Http;
using System.Web.Http.SelfHost;


namespace selfHostServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:3030");
            config.Routes.MapHttpRoute("default", "api/{controller}/{id}");

            HttpSelfHostServer myServer = new HttpSelfHostServer(config);
            myServer.OpenAsync().Wait();
            Console.ReadLine();
        }
    }
}
