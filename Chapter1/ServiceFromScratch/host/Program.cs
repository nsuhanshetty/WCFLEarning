using System;
using System.ServiceModel;

namespace host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloIndigo.HelloIndigoService),new Uri("http://localhost:8000/HelloIndigo")))
            {
                host.AddServiceEndpoint(typeof(HelloIndigo.IHelloIndigoService), new BasicHttpBinding(), "HelloIndigoServiceName");
                host.Open();

                Console.WriteLine("Press <ENTER> to terminate the Service Host");
                Console.ReadLine();
            }
        }
    }
}
