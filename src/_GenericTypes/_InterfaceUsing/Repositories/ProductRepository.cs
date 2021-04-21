using System.Collections.Generic;
using _InterfaceUsing.Models;

namespace _InterfaceUsing.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        public void Add(Product item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}