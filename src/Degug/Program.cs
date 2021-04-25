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
            List<string> list = new List<string>()
            {
                "one",
                "two",
                "three"
            };

            var x = list.Find(x => x.Contains("three"));
            
        }       

    }

}
