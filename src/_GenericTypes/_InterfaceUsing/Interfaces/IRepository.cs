using System.Collections.Generic;
using _InterfaceUsing.Models;

namespace _InterfaceUsing
{
    public interface IRepository<T> where T: class
    {
        void Add(T item);
        IEnumerable<T> Get();
    }
}