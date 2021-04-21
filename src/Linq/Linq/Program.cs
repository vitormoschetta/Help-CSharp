using System;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.PopularListaPessoas();
            pessoa.ImprimePessoasMaiorDeIdade();            
            pessoa.ImprimePessoasOrdenadasPeloNome();            
            pessoa.ImprimePessoasComNomeVitor();            
            pessoa.ImprimePessoasAgrupadasPeloNome();            
        }
    }
}
