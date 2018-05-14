using System.ServiceModel;

namespace Host
{
    class MyServiceHost
    {
        static ServiceHost myServiceHost;
        internal static void StartService()
        {
            myServiceHost = new ServiceHost(typeof(HelloIndigoService));
            myServiceHost.Open();
        }

        internal static void StopService()
        {
            myServiceHost.Close();
        }
    }
}
