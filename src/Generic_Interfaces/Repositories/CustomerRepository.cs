using System.Collections.Generic;
using Interfaces.Models;

namespace Interfaces.Repositories
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