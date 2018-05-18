using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostA = null;
            ServiceHost hostB = null;

            try
            {
                hostA = new ServiceHost(typeof(BusinessServices.ServiceA));
                hostB = new ServiceHost(typeof(BusinessServices.ServiceB));

                hostA.Open();
                hostB.Open();

                Console.WriteLine();
                Console.WriteLine("Press <ENTER> to terminate the host service");
                Console.ReadLine();
            }
            finally
            {
                hostA.Close();
                hostB.Close();
            }
        }
    }
}
