using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    public class MetodosComRetorno
    {
        public static Task<string> MetodoA()
        {
            Thread.Sleep(2000);
            return Task.FromResult("Metodo A");
        }

        public static Task<string> MetodoB()
        {
            Thread.Sleep(2000);
            return Task.FromResult("Metodo B");
        }

        public static Task<string> MetodoC()
        {
            Thread.Sleep(2000);
            return Task.FromResult("Metodo C");
        }
    }
}