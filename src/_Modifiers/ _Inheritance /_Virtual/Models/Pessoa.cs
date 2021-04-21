using System.Collections.Generic;

namespace _Virtual.Models
{
    public class Pessoa
    {
        protected List<Pessoa> list = new List<Pessoa>();
        public int Id { get; set; }
        public string Nome { get; set; }


        public virtual void Add(Pessoa item)
        {
            item.Id = list.Count + 1;
            list.Add(item);
        }

        public List<Pessoa> Get() => list;
    }


}