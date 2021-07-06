using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Shared;

namespace Degug
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteProcessosAsync2();
        }

        static void ExecuteProcessosAsync2()
        {
            Task.Run(() =>
            {
                Processos.ProcessoA();
                Processos.ProcessoB();
                Processos.ProcessoC();
            });
        }
    }
}
