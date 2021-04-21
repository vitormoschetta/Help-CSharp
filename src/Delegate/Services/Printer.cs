using System;

namespace Delegate.Services
{
    public class Printer
    {
        private void Print()
        {
            Console.WriteLine("Imprimindo..");
        }

        public DelPrint PublicPrint()
        {
            DelPrint del = new DelPrint(Print);
            return del;
        }
    }
    
}