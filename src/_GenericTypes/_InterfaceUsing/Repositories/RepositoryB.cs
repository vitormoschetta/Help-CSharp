using System.Collections.Generic;
using _InterfaceUsing.Models;

namespace _InterfaceUsing.Repositories
{
    public class RepositoryB : IRepositoryB<ProductStruct>
    {
        public void Add(ProductStruct item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ProductStruct> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}