using _InterfaceUsing.Models;

namespace _InterfaceUsing.Repositories
{
    public class RepositoryC : IRepositoryC<Product, ProductStruct>
    {
        public void Add(Product item, ProductStruct itemB)
        {
            throw new System.NotImplementedException();
        }
    }
}