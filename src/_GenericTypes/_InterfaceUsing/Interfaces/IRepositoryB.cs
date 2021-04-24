using System.Collections.Generic;

namespace _InterfaceUsing
{
    // Essa interface diz que T precisa ser um struct, ou seja, não podemos mais utilizar 'string' nem 'product'
    // O tipo deve ser informado no ato da implementação:
    // e.g: Repository: IRepositoryB<ProductStruct>
    

    public interface IRepositoryB<T> where T: struct
    {
        void Add(T item);
        IEnumerable<T> Get();
    }
}