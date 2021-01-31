using System;

namespace delegado
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploDeDelegate.teste();
        }
    }    

    public delegate void SimplesDelegate();
    public class ExemploDeDelegate
    {
        public static void minhaFuncao()
        {
            Console.WriteLine("Eu fui chamada por um delegate ...");
        }

        public static void teste()
        {            
            SimplesDelegate simplesDelegate = new SimplesDelegate(minhaFuncao);
            
            simplesDelegate();            
        }
    }
}
