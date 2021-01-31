using System.Collections.Generic;

namespace Interfaces.Repositories
{
    public class PessoaRepository
    {
        private List<IPessoa> list = new List<IPessoa>();

        public void Add(IPessoa item)
        {            
            item.Id = list.Count + 1;
            list.Add(item);
        }

        public List<IPessoa> Get()
        {
            return list;
        }
    }
}