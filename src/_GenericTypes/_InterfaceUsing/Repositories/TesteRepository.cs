using System.Collections.Generic;
using _InterfaceUsing.Models;

namespace _InterfaceUsing.Repositories
{
    public class TesteRepository : IRepositoryB<IEnumerable<string>>
    {
        public void Add(IEnumerable<string> item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IEnumerable<string>> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}