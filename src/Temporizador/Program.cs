using System;

namespace Temporizador
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clique para Iniciar");
			var a = Console.ReadLine();
			Processador.processar();
        }
    }
}
