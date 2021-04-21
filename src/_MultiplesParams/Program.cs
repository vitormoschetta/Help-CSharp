using System;

namespace _MultiplesParams
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = string.Empty;
            var sobrenome = string.Empty;
            
            
            (nome, sobrenome) = Teste();


            // três formas de fazer concatenar os nomes:
            Console.WriteLine(nome + " " + sobrenome);
            Console.WriteLine("{0} {1}", nome, sobrenome);
            Console.WriteLine($"{nome} {sobrenome}");

        }

        static (string, string) Teste()
        {
            return ("Vitor", "Moschetta") ;
        }        
    }
}
