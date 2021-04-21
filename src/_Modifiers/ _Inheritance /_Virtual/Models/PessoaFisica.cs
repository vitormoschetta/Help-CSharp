namespace _Virtual.Models
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
        public string Cpf { get; set; }
    }
}