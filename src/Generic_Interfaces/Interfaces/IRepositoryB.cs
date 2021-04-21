using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepositoryB<T> where T: IEnumerable<string>
    {
        void Add(T item);
        IEnumerable<T> Get();
    }
}