using System;
using System.Threading;
using Shared;

namespace _Start
{
    class Program
    {
        static void Main(string[] args)
        {
            // aqui estamos criando uma Thread para cada método, ou seja, eles irão executar em paralelo:
            var threadA = new Thread(Methods.MetodoA); 
            var threadB = new Thread(Methods.MetodoB); 
            var threadC = new Thread(Methods.MetodoC); 
            threadA.Start();
            threadB.Start();
            threadC.Start();

            Console.WriteLine("\nProceso concluído!");

            // perceba que esta mensagem de conclusão irá aparecer antes do término do processo... 
            // isso acontece porque estamos com processos independentes rodando, ou seja, a linha de comando não
            // aguarda a conclusão do processo que está em outra thread. 
        }
    }
}
