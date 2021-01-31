namespace Interfaces.Models
{
    public class Cliente : IPessoa
    {
        public Cliente(string name)
        {        
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}