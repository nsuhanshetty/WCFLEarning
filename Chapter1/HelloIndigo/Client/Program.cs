using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.HelloIndigoServiceClient proxy = new Client.localhost.HelloIndigoServiceClient();
            string s = proxy.HelloIndigo();
            Console.WriteLine(s);

            Console.WriteLine("Press <ENTER> to terminate the Host application");
            Console.ReadLine();
        }
    }
}
