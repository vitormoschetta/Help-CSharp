using System;
using System.Collections.Generic;
using System.Linq;

namespace _String
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

            List<string> lista = new ItemsString().simpleArraySum();
            Console.WriteLine(string.Join(", ", lista));
            // string.Join coloca uma lista em uma string. 
            // O 1º parâmetro é o 'caractere separador', o 2º é a lista.            



        }
    }

    public class ItemsString
    {
        public string stringLIst;
        public ItemsString()
        {
            stringLIst = "Vitor, Porto Velho, 31 anos.";
        }
        public List<string> simpleArraySum()
        {
            List<string> lista = stringLIst.Split(',')  //<-- separamos a string por virgula, 
                                    .ToList();          // retornando uma lista (ToList)

            return lista;
        }
    }
}
