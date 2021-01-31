using System;
using System.Linq;
using Interfaces.Models;
using Interfaces.Repositories;

namespace interfaces
{
    class Program
    {
        // Neste exemplo, conseguimos salvar 'Cliente' e 'Funcionario' em um mesmo
        // repositório. Dois tipos diferentes de dados sendo salvos em uma mesma lista.
        // Isso é possível graças a interface 'IPessoa'. 
        // Uma interface é uma abstração. Cliente e Funcionario são suas implementações.
        // Nosso repositório não está dependendo das implementações, mas da abstração.
        // Logo, podemos adicionar à nossa lista de repositório qualquer objeto que 
        // implemente a interface IPessoa.
        static void Main(string[] args)
        {
            var clienteA = new Cliente("Cliente A");
            var funcionarioA = new Funcionario("Funcionario A", "doc 01");

            var repository = new PessoaRepository();            

            repository.Add(clienteA);
            repository.Add(funcionarioA);

            Console.WriteLine(string.Join(", ", repository.Get().Select(x => x.Name)));            
        }
    }
}
