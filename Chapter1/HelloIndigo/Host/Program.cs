using System;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyServiceHost.StartService();

                Console.WriteLine("Press <ENTER> to terminate the Host application");
                Console.ReadLine();
            }
            finally
            {
                MyServiceHost.StopService();
            }
            
        }
    }
}
