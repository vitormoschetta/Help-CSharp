using System;

namespace _Project
{
    class Program
    {
        static void Main(string[] args)
        {
            GetShared();            
        }


        static void GetShared()
        {
            var assembly = typeof(Shared.Processos).Assembly;
            Console.WriteLine(assembly);

            Type type = typeof(Shared.Processos);
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
