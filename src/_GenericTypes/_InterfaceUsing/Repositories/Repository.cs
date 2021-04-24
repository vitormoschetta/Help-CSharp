using System.Collections.Generic;

namespace _InterfaceUsing.Repositories
{
    public class Repository : IRepository<string>
    {
        public void Add(string item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<string> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}