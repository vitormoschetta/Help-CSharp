using System;

namespace _Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = typeof(dll.Metodos).Assembly;
            Console.WriteLine(assembly);

            Type type = typeof(dll.Metodos);
            Console.WriteLine(type);            

            // descobrir propriedades e métodos de uma classe em uma dll:            
            var methods = type.GetMethods();            
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }
            
        }
    }
}
