using System.Collections.Generic;

namespace _InterfaceUsing
{
    public interface IRepositoryB<T> where T: IEnumerable<string>
    {
        void Add(T item);
        IEnumerable<T> Get();
    }
}