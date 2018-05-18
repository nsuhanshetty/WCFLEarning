using BusinessServiceContracts;

namespace BusinessServices
{
    public class ServiceA : IServiceA, IAdmin
    {
        string IAdmin.AdminOperation1()
        {
            return "IAdmin.AdminOperation1 Invoked";
        }

        string IAdmin.AdminOperation2()
        {
            return "IAdmin.AdminOperation2 Invoked";
        }

        string IServiceA.Operation1()
        {
            return "IServiceA.Operation1 Invoked";
        }

        string IServiceA.Operation2()
        {
            return "IServiceA.Operation2 Invoked";
        }
    }
}
