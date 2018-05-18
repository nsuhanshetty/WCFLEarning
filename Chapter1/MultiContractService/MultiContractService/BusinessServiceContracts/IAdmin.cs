using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BusinessServiceContracts
{
    [ServiceContract]
    public interface IAdmin
    {
        [OperationContract]
        string AdminOperation1();
        [OperationContract]
        string AdminOperation2();
    }
}
