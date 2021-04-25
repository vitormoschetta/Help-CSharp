using System;
using System.Collections.Generic;
using System.Linq;

namespace _Dictionary
{
    class Program
    {
        static Dictionary<string, string> dict = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            try
            {
                SetDict();
                ExploreDict();
                ExploreDictLinq();

                // A key 03 já existe no Dicionário, ao tentar adicionar novamente levantamos uma exeção            
                dict.Add("03", "Ruby");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void SetDict()
        {
            dict.Add("01", "C#");
            dict.Add("02", "Python");
            dict.Add("03", "NodeJS");
        }

        static void ExploreDict()
        {
            Console.WriteLine("\n");

            Console.WriteLine(string.Join("; ", dict.Keys));
            Console.WriteLine(string.Join("; ", dict.Values));

            Console.WriteLine(dict.ContainsKey("04"));
            Console.WriteLine(dict.ContainsValue("C#"));

            Console.WriteLine(dict.Count);

            dict.Remove("01");
            Console.WriteLine(string.Join("; ", dict.Values));

            dict.TryGetValue("02", out string valor);
            Console.WriteLine(valor);
        }


        static void ExploreDictLinq()
        {
            Console.WriteLine("\n");

            Console.WriteLine(dict.FirstOrDefault(x => x.Key == "02"));
        }
    }
}
