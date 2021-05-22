using System;

namespace _Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            // O ENUM é uma "propriedade" que só pode conter os valores nele declarados
            // É ótimo para ser usado quando precisamos limitar os valores possíveis de uma propriedade
            // Também muito utilizado para armazenar valores / parâmetros estáticos.
            
            var cor = CoresBotao.Azul;
            if (cor == (CoresBotao)1)
                Console.WriteLine("Verdadeiro");

            Console.WriteLine(cor);
        }

        enum CoresBotao
        {
            Azul = 1,
            Vermelho = 2,
            Verde = 3
        }
    }
}
