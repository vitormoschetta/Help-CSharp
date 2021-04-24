using System.Collections.Generic;
using _InterfaceUsing.Interfaces;
using _InterfaceUsing.Models;

namespace _InterfaceUsing.Repositories
{
    public class RepositoryD : IRepositoryD<Product>
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

    public class RepositoryE : IRepositoryD<Customer>
    {
        public void Add(Customer item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Customer> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}