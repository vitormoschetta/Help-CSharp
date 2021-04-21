using System;
using System.Collections.Generic;
using System.Linq;

namespace _LinqToLambda
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public List<Pessoa> Pessoas;
        public void PopularListaPessoas()
        {
            Pessoas = new List<Pessoa>()
            {
                new Pessoa() { Nome = "Vitor Hugo", Idade = 31 },
                new Pessoa() { Nome = "Cristiane Costa", Idade = 35 },
                new Pessoa() { Nome = "Vitor Melquisedeque", Idade = 8 },
                new Pessoa() { Nome = "Christian Riquellme", Idade = 12 },
                new Pessoa() { Nome = "Vitor Hugo", Idade = 18 },
            };
        }
        

        public void ImprimePessoasMaiorDeIdade()
        {
            var filtroPessoas = Pessoas
                                .Where(x => x.Idade > 18)
                                .Select(x => x.Nome);

            Console.WriteLine("\n LAMBDA - Pessoas maiores de idade: ");
            foreach (var item in filtroPessoas)
                Console.WriteLine(item);

        }


        public void ImprimePessoasOrdenadasPeloNome()
        {
            var filtroPessoas = Pessoas
                                .OrderBy(x => x.Nome)
                                .Select(x => x.Nome);

            Console.WriteLine("\n LAMBDA - Pessoas ordenadas pelo nome: ");
            foreach (var item in filtroPessoas)
                Console.WriteLine(item);
        }


        public void ImprimePessoasComNomeVitor()
        {
            var filtroPessoas = Pessoas
                                .Where(x => x.Nome.Contains("Vitor"))
                                .Select(x => x.Nome);

            Console.WriteLine("\n LAMBDA - Pessoas que possuem o nome 'Vitor': ");
            foreach (var item in filtroPessoas)
                Console.WriteLine(item);
        }


        public void ImprimePessoasAgrupadasPeloNome()
        {
            var filtroPessoas = Pessoas.GroupBy(x => x.Nome);

            Console.WriteLine("\n Pessoas agrupadas por nome (não repete se tiver mesmo nome): ");
            foreach (var item in filtroPessoas)
                Console.WriteLine(item.Key);
        }
    }
}