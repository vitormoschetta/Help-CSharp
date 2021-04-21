using System;
using System.Linq;
using _Virtual.Models;

namespace _Virtual
{
    class Program
    {
        // A classe pessoa possui o método 'Add' marcado com o modificador 'virtual'.
        // Isso quer dizer que esse método pode ser herdado e usado da forma que já 
        // está implementado, mas também pode ser SOBRESCRITO. 
        // Portanto, o modificador 'virtual' permite a sobrescrita do método através 
        // da palavra chave 'override'.
        // Veja que a classe 'PessoaJuridica' faz essa sobrescrita. Ja a clase 
        // 'PessoaFisica' não, apenas usa o que já está implementado na classe 'Pessoa'.        
        static void Main(string[] args)
        {
            var pessoaFisica = new PessoaFisica("fulano", "00000000000");
            pessoaFisica.Add(pessoaFisica);

            var pessoaJuridica = new PessoaJuridica("fulato LTDA", "00000000000111");
            pessoaJuridica.Add(pessoaJuridica);

            Console.WriteLine(string.Join(", ", pessoaFisica.Get().Select(x => x.Id)));
            Console.WriteLine(string.Join(", ", pessoaJuridica.Get().Select(x => x.Id)));            
        }
    }
}
