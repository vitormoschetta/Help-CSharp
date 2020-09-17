using System;
using System.Collections.Generic;
using System.Linq;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.PopularListaPessoas();
            pessoa.ImprimePessoasMaiorDeIdade_Linq();
            pessoa.ImprimePessoasMaiorDeIdade_Lambda();
            pessoa.ImprimePessoasOrdenadasPeloNome_Linq();
            pessoa.ImprimePessoasOrdenadasPeloNome_Lambda();
            pessoa.ImprimePessoasComNomeVitor_Linq();
            pessoa.ImprimePessoasComNomeVitor_Lambda();
            pessoa.ImprimePessoasAgrupadasPeloNome_Linq();
            pessoa.ImprimePessoasAgrupadasPeloNome_Lambda();

        }
    }
}
