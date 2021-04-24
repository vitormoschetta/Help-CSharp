using System.Collections.Generic;
using _InterfaceUsing.Models;

namespace _InterfaceUsing.Interfaces
{
    // Essa interface diz que T precisa ser uma classe do tipo Base, pondendo inclusive ser uma classe filha...
    // Como tanto Product quanto Customer herdam da classe Base, logo na implementação pode ser usada qualquer 
    // dessas classes.    
    // O tipo deve ser informado no ato da implementação:
    // e.g: Repository: IRepositoryD<Product>
    // e.g: Repository: IRepositoryD<Customer>
    public interface IRepositoryD<T> where T: Base 
    {
        void Add(T item);
        IEnumerable<T> Get();
    }
}