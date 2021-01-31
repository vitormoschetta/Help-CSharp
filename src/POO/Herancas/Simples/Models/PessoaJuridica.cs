namespace Heranca.Models
{
    public class PessoaJuridica : Pessoa
    {
         public PessoaJuridica(string nome, string cnpj)
        {
            Nome = nome;
            Cnpj = cnpj;
        }
        public string Cnpj { get; set; }
    }
}