using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] parametros = { "Porto Velho-RO", 31 };

            string mensagem = string.Format("Moro em {0}, tenho {1} anos.", parametros);
            Console.WriteLine(mensagem);

            string mensagem2 = $"Moro em {parametros[0]}, tenho {parametros[1]} anos.";
            Console.WriteLine(mensagem2);

            // string.Join coloca uma lista em uma string. 
            // O 1º parâmetro é o 'caractere separador', o 2º é a lista.
            Console.WriteLine("Moro em " + string.Join(", ", parametros) + " anos.");


        }
    }
}
