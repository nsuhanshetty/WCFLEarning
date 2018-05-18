using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessServiceContracts;

namespace BusinessServices
{
    public class ServiceB : IAdmin,IServiceB
    {
        string IAdmin.AdminOperation1()
        {
            return "IAdmin.AdminOperation1 Invoked";
        }

        string IAdmin.AdminOperation2()
        {
            return "IAdmin.AdminOperation2 Invoked";
        }

        string IServiceB.Operation3()
        {
            return "IServiceB.Operation3 Invoked";
        }
    }
}
