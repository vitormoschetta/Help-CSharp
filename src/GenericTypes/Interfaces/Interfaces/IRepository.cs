using System.Collections.Generic;
using Interfaces.Models;

namespace Interfaces
{
    public interface IRepository<T> where T: class
    {
        void Add(T item);
        IEnumerable<T> Get();
    }
}