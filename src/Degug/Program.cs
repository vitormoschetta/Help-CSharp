using System.Threading.Tasks;
using Shared;

namespace Degug
{
    class Program
    {
        static void Main(string[] args)
        {            
            Parallel.Invoke(
                () => Execute(), 
                () => Execute2());
        }

        static void Execute()
        {
           Processos.ProcessoA();
           Processos.ProcessoB();
           Processos.ProcessoC();
        }

        static void Execute2()
        {
            var tarefas = new Task[3];
            tarefas[0] = ProcessosAsync.ProcessoA();
            tarefas[1] = ProcessosAsync.ProcessoB();
            tarefas[2] = ProcessosAsync.ProcessoC();
        
            Task.WaitAll(tarefas);
        }
    }
}
