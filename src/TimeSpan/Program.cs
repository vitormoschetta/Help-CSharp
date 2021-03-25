using System;

namespace IntervaloTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2021, 3, 25, 8, 30, 0);
            DateTime date2 = new DateTime(2021, 3, 25, 8, 39, 0);

            TimeSpan interval = date2 - date1;

            Console.WriteLine("Primeira marcação: {0}; Segunda marcação: {1};", date1, date2);            
            Console.WriteLine("Intervalo de tempo: " + interval);
        }
    }
}
