using System;

namespace Descartes
{
    class Program
    {        
        static void Main(string[] args)
        {
            PrintA();
            PrintB();
        }

        static (string, string, int) InformacoesPessoais()
        {
            string nome = "Vitor";
            string sobrenome = "Moschetta";
            int idade = 31;

            return (nome, sobrenome, idade) ;
        }

        static void PrintA()
        {
            (string nome, string sobrenome, int idade) = InformacoesPessoais();
            
            Console.WriteLine("{0} {1}, {2} anos.", nome, sobrenome,idade);
        }


        // Neste método eu quero imprimir apenas o nome e sobrenome, como poderia evitar de ter 
        // que declarar a variavel para o parametro idade? Usando '_' (descarte):
        static void PrintB()
        {
            (string nome, string sobrenome, _) = InformacoesPessoais();
            
            Console.WriteLine("{0} {1}", nome, sobrenome);
        }
    }
}
