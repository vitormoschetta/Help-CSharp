namespace Interfaces.Models
{
    public class Funcionario : IPessoa
    {
        public Funcionario(string name, string doc)
        {
            Name = name;
            Doc = doc;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Doc { get; set; }
    }
}