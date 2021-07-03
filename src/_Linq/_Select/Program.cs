using System;
using System.Collections.Generic;
using System.Linq;

namespace _Select
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = GetItems();
            Console.WriteLine(string.Join(" | ", items));

            // a cláusula select me permite dizer o que eu quero retornar durante a iteração da lista (posso mudar os itens da lista)
            var items2 = GetItems().Select(x => "name: " + x);
            Console.WriteLine(string.Join(" | ", items2));
            
            // outro exemplo - com objeto:
            var items3 = GetObjectItems().Select(x => x.Id);
            Console.WriteLine(string.Join(" | ", items3));

        }

        static List<string> GetItems()
        {
            return new List<string>(){
                "item 01",
                "item 02",
                "item 03",
                "item 04",
                "item 05",
                "item 06",
            };
        }

        static List<Product> GetObjectItems()
        {
            return new List<Product>() {
                new Product("product 01"),
                new Product("product 02"),
                new Product("product 03"),
            };
        }
    }


    class Product
    {
        public Product(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
