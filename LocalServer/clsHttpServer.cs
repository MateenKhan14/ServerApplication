using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalServer
{
    public class clsHttpServer : HttpServer
    {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="port"></param>
        public clsHttpServer(int port)
            : base(port)
        {
        }
        public override void handleGETRequest(HttpProcessor p)
        {

            Console.WriteLine("request: {0}", p.http_url);
            p.writeSuccess();
            p.outputStream.WriteLine("<html><body><h1>Index Page from My test server</h1>");
            p.outputStream.WriteLine("Current Time: " + DateTime.Now.ToString());

        }

    }

}
