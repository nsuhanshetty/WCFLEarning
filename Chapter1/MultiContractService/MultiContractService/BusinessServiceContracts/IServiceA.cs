using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BusinessServiceContracts
{
    [ServiceContract]
    public interface IServiceA
    {
        [OperationContract]
        string Operation1();
        [OperationContract]
        string Operation2();
    }
}
