using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
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
            var filtroPessoas = from p in Pessoas
                                where p.Idade > 18
                                select p.Nome;

            Console.WriteLine("\n LINQ - Pessoas maiores de idade: ");
            foreach (var item in filtroPessoas)
                Console.WriteLine(item);

        }

       
        public void ImprimePessoasOrdenadasPeloNome()
        {
            var filtroPessoas = from p in Pessoas
                                orderby p.Nome ascending
                                select p.Nome;

            Console.WriteLine("\n LINQ - Pessoas ordenadas pelo nome: ");
            foreach (var item in filtroPessoas)
                Console.WriteLine(item);
        }
     

        public void ImprimePessoasComNomeVitor()
        {
            var filtroPessoas = from p in Pessoas
                                where p.Nome.Contains("Vitor")
                                select p.Nome;

            Console.WriteLine("\n LINQ - Pessoas que possuem o nome 'Vitor': ");
            foreach (var item in filtroPessoas)
                Console.WriteLine(item);
        }      


        public void ImprimePessoasAgrupadasPeloNome()
        {
            var filtroPessoas = from p in Pessoas
                                group Nome by p.Nome;

            Console.WriteLine("\n Pessoas agrupadas por nome (não repete se tiver mesmo nome): ");
            foreach (var item in filtroPessoas)
                Console.WriteLine(item.Key);
        }
     
    }
}