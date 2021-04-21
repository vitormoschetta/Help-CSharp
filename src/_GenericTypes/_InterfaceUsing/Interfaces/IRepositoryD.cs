namespace _InterfaceUsing
{
    public interface IRepositoryD<T> where T : notnull
    {
        void Add(T item);
    }
}