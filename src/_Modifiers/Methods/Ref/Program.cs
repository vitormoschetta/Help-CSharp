using System;

namespace Ref
{
    // usamos ref para passar a variável por referência...
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;

            var result = RaizQuadrada(number);
            Console.WriteLine(result); // outpub: 4

            RaizQuadradaRef(ref number);
            Console.WriteLine(number); // outpub: 4      
        }


        // Com ref
        // Perceba que aqui não é gerado um novo local na memória para o valor de number, 
        // o ponteiro permanece apontando para o mesmo local, apenas atualizando o valor de 'number,
        // por isso não precisamos retornar nada. 
        static void RaizQuadradaRef(ref int number)
        {
            number = number * number;
        }


        // Sem ref
        // Aqui o que o processador faz é criar um novo local na memória pra armezenar um novo 'number',
        // e por isso precisamos retornar seu valor para o chamador.
        static int RaizQuadrada(int number)
        {
            return number * number;
        }
    }
}
