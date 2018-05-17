using System.Threading.Tasks;

namespace Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloIndigoService" in both code and config file together.

    public class HelloIndigoService : IHelloIndigoService
    {
        public string HelloIndigo()
        {
            return "Hello Indigo";
        }

        //public async Task HelloIndigoAsync()
        //{
        //    await Task.Run(() => HelloIndigo());
        //}
    }
}
