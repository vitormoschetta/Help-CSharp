using System;
using System.Threading;
using System.Threading.Tasks;

namespace _Async
{
    public class SanduicheAsync
    {
        public async Task Execute()
        {
            await AddPao();
            await AddQueijo();
            await AddPresunto();
        }
        private async Task AddPao()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Adicionado Pao Integral");
        }

        private async Task AddQueijo()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Adicionado Queijo Mussarela");
        }

        private async Task AddPresunto()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Adicionado Apresuntado Defumado");
        }
    }
}