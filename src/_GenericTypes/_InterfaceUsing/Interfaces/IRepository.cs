using System.Collections.Generic;
using _InterfaceUsing.Models;

namespace _InterfaceUsing
{
    // Essa interface nos permite implementar qualquer tipo.
    // O tipo deve ser informado no ato da implementação:
    // e.g: Repository: IRepository<string>
    // e.g: ProductRepository : IRepository<Product>    
    public interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> Get();
    }
}