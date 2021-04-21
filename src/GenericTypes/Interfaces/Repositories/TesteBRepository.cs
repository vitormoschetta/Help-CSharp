using Interfaces.Models;

namespace Interfaces.Repositories
{
    public class TesteBRepository : IRepositoryC<Product, Teste>
    {
        public void Add(Product item, Teste itemB)
        {
            throw new System.NotImplementedException();
        }
    }
}