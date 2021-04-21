namespace _Virtual.Models
{
    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome, string cnpj)
        {
            Nome = nome;
            Cnpj = cnpj;
        }
        public string Cnpj { get; set; }

        public override void Add(Pessoa item)
        {
            item.Id = list.Count + 100;
            list.Add(item);
        }
    }
}