using System;
using System.ServiceModel;

namespace HelloIndigo
{
    /// <summary>
    /// Service Type
    /// </summary>
    public class HelloIndigoService : IHelloIndigoService
    {
        public string HelloIndigo()
        {
            return "Hello Indigo";
        }
    }

    /// <summary>
    /// Service Contract
    /// </summary>
    [ServiceContract(Namespace = "http://www.thatindigogirl.com/samples/2006/06")]
    public interface IHelloIndigoService
    {
        [OperationContract]
        string HelloIndigo();
    }
}
