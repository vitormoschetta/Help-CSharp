using System;

namespace _InterfaceUsing
{
    // Essa interface diz que T precisa ser uma classe e T um Struct.
    // O tipo deve ser informado no ato da implementação:
    // e.g: Repository: IRepositoryC<Product, ProductStruct>

    public interface IRepositoryC<T, U> 
        where T: class
        where U: struct
    {
        void Add(T item, U itemB);     
          
    }
}