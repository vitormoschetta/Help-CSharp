using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Degug
{

    class Program
    {        
        static void Main(string[] args)
        {   
            List<Product> list = new List<Product>()
            {
                new Product("one"),
                new Product("two"),
                new Product("three")
            };

            // criar uma lista somente leitura a partir de outra lista
            var listReadOnly = list.AsReadOnly();

            // bool para verificação de existencia ... 
            var contains = list.Exists(x => x.Name.Contains("one")); 

            
            
        }       

    }

}
