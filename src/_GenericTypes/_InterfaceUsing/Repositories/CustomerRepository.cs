using System.Collections.Generic;
using _InterfaceUsing.Models;

namespace _InterfaceUsing.Repositories
{
    public class CustomerRepository : IRepository<Customer>
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