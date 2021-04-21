using System;

namespace _InterfaceUsing
{
    public interface IRepositoryC<T, U> 
        where T: class
        where U: struct
    {
        void Add(T item, U itemB);       
    }
}