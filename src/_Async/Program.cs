using System;
using System.Threading;

namespace _Async
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sanduiche.Execute();
            var sanduicheAsync = new SanduicheAsync();
            sanduicheAsync.Execute();
        }

        
    }
}
