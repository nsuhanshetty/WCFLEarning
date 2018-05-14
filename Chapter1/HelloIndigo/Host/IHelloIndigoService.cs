using System.ServiceModel;

namespace Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloIndigoService" in both code and config file together.
    [ServiceContract(Namespace ="http://www.thatindidogirl.com/samples/2006/06")]
    public interface IHelloIndigoService
    {
        [OperationContract]
        string HelloIndigo();
    }
}
