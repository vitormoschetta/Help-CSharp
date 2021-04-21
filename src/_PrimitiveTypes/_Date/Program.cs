using System;

namespace _Date
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DateTime(2020, 9, 16);


            // Data e hora
            Console.WriteLine(data);

            // Data
            Console.WriteLine(data.ToString("d"));

            // Data por extenso
            Console.WriteLine(data.ToLongDateString());

            // Data atual
            Console.WriteLine(DateTime.Today);

            // Data atual - 2 dias
            Console.WriteLine(DateTime.Today.AddDays(-2));

            // quantos dias o ano teve até agora:
            var dataAtual = DateTime.Today;
            var inicio = new DateTime(2020, 1, 1);
            var dias = (dataAtual - inicio).Days;
            Console.WriteLine(dias);

            // Customizados
            Console.WriteLine(data.ToString("dd . MM . yyyy"));
            Console.WriteLine(data.ToString("dd/MM/yyyy  hh:mm:ss"));
            Console.WriteLine(data.ToString("MM/yyyy"));

        }
    }
}
