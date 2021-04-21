using System;
using Joins.Models;

namespace Joins
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            var semEstoque = stock.GetItemsOutOfStock();
            Console.WriteLine(string.Join(", ", semEstoque));

            bool existItemZerado = stock.ExisteItemZerado();
            if (existItemZerado)
                Console.WriteLine("Existe itens com estoque zero.");
        }
    }
}
