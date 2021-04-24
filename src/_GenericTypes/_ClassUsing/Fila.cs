using System.Collections.Generic;

namespace _ClassUsing
{
    // Como a classe Fila utiliza um T Generic, podemos trabalhar com qualquer tipo de dados.
    // Definimos o tipo de dados no momento da instancia da classe Fila:
    // e.g: new Fila<string>()
    // e.g: new Fila<Product>()
    public class Fila<T>
    {
        List<T> fila;
        public Fila()
        {
            fila = new List<T>();
        }
        public Fila(List<T> item)
        {
            fila = new List<T>();
            fila = item;
        }

        public void AddElementoFila(T item)
        {
            fila.Add(item);
        }

        public void AddElementoFila(List<T> items)
        {
            if (fila.Count > 0)
            {
                var index = fila.Count;
                for (int i = 0; i < items.Count; i++)
                {
                    fila.Insert(i, items[i]);
                }                
            }
            else
            {
                fila = items;
            }
            
        }

        public T ConsomeFila()
        {
            if (fila.Count > 0)
            {
                var item = fila[fila.Count - 1];
                fila.RemoveAt(fila.Count - 1);
                return item;
            }
            throw new System.Exception("Fila está vazia!");
        }


        public List<T> GetElements()
        {
            return fila;
        }
    }
}