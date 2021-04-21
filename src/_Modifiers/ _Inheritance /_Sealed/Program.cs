using System;

namespace _Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
            // ao usar o modificador 'sealed' na classe 'Pessoa', estou informando
            // que esta classe não pode ser Herdada, apenas instanciada. 
            // Logo, o exemplo da classe abaixo (PessoaFisica) não funcionará.
        }
    }

    // public class PessoaFisica : Pessoa
    // {  }
}
