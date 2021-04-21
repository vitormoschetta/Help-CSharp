using System;
using _Abstract.Models;

namespace _Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoaFisica = new PessoaFisica("fulano", "00000000000");     
            var PessoaJuridica = new PessoaJuridica("empresa ltda", "12345678945678");


            // Não será possível instanciar a classe 'Pessoa' diretamene, pois ela está setada como
            // uma classe 'Abstract', ou seja, só pode ser herdada e não instanciada:            

            //var pessoa = new Pessoa();       
        }
    }
}
