using System;

namespace Delegate
{
    public class Impressora
    {
        private static void Imprimir()
        {
            Console.WriteLine("Imprimindo..");
        }

        public static DelImprimir ImprimirPublic()
        {
            DelImprimir del = new DelImprimir(Imprimir);
            return del;
        }
    }

    public delegate void DelImprimir();
}