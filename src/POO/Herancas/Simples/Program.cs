using System;
using Heranca.Models;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoaFisica = new PessoaFisica("fulano", "00000000000");     
            var PessoaJuridica = new PessoaJuridica("empresa ltda", "12345678945678");

            // Vamos supor que o preenchimento do CPF (pessao fisica) e CNPJ (pessoa juridica)
            // tenha que ser algo obrigatório. Olha o que vamos fazer a baixo:

            var pessoa = new Pessoa();       

            // temos que impedir que a classe pessoa seja instanciada, ela só pode ser herdada.
            // vamos ver isso na secao 'Abstract'
        }
    }
}
