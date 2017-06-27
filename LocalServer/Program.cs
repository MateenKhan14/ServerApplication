using System;
using System.Threading;

namespace LocalServer
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpServer httpServer;
            if (args.GetLength(0) > 0)
            {
                httpServer = new clsHttpServer(Convert.ToInt16(args[0]));
            }
            else
            {
                httpServer = new clsHttpServer(8080);
            }
            Thread thread = new Thread(new ThreadStart(httpServer.listen));
            thread.Start();
            Console.WriteLine("Mateen's Test Server Started");
            Console.WriteLine("Open any Browser and type http://localhost:8080/ to request the server");
            //return 0;
        }
    }
}
