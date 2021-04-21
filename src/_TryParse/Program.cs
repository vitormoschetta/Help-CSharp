using System;

namespace _TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
           ExemploA();
           Console.WriteLine("\n");
           ExemploB();
        }

        static void ExemploA()
        {
            String[] valores = { null, "160519", "9432.0", "16,667","-322", "+4302", "(100);", "01FA" };
            foreach (var valor in valores)
            {                                 
                Int32.TryParse(valor, out int numero);
                if (numero != 0)
                {
                    Console.WriteLine("Conversão de '{0}' para {1}.", valor, numero);
                }
                else
                {
                    Console.WriteLine("A conversão de '{0}' Falhou.",valor == null ? "<null>" : valor);
                }
            }            
        }


        static void ExemploB()
        {
            String[] valores = { null, "160519", "9432.0", "16,667","-322", "+4302", "(100);", "01FA" };
            foreach (var valor in valores)
            {                                
                bool success = Int32.TryParse(valor, out int numero);
                if (success)
                {
                    Console.WriteLine("Conversão de '{0}' para {1}.", valor, numero);
                }
                else
                {
                    Console.WriteLine("A conversão de '{0}' Falhou.",valor == null ? "<null>" : valor);
                }
            }            
        }
    }
}
