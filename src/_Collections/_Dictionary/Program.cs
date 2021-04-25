using System;
using System.Collections.Generic;

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
                ExploreMethods();
                       
                dict.Add("03", "Ruby"); 
                // A key 03 já existe na coleção, ao tentar adicionár uma Key já existente tomamos uma exceção   
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

        static void ExploreMethods()
        {            
            bool contains = dict.ContainsKey("04"); // false

            contains = dict.ContainsValue("C#"); // true
            
            int count = dict.Count; // 3

            dict.Remove("01"); // remove C#            

            dict.TryGetValue("02", out string item); // item = Python        

            string valueA = dict["02"]; // valueA = Python            
        }

    }
}
