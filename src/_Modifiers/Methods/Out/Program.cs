using System;

namespace Out
{
    // usando 'out' podemos passar um parâmetro sem precisar declará-lo antes. É importante perceber que esta variável já fica disponível no escopo de origem, 
    // apos a passagem do método.
    // Obs: passagem por referência.
    class Program
    {
        static void Main(string[] args)
        {            
            RaizQuadrada(out int number);
            Console.WriteLine(number); // outpub: 1989         
        }

        
        // Aqui a variavel 'number' tbm é passada como refência, porém ao utilizar a palavra reservada
        // 'out', podemos passar a varável sem precisá-la iniciar (atribuir valor).
        static void RaizQuadrada(out int number)
        {
            number = 1989;
        }
    }
}
