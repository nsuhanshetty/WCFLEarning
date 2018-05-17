using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloIndigoServiceClient proxy = new HelloIndigoServiceClient();
            string s = proxy.HelloIndigo();
            Console.WriteLine(s);

            Console.WriteLine("Press <ENTER> to terminate the client");
            Console.ReadLine();
        }
    }
}
