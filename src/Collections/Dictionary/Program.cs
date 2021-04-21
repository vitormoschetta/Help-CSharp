using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("01", "C#");
            dict.Add("02", "Python");
            dict.Add("03", "NodeJS");

            try
            {
                dict.Add("03", "Ruby");
                // Ao tentar adicionar novamente a Key '03' vai levantar uma exceção
            }
            catch (Exception ex)
            {                
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine(string.Join("; ", dict));
                // Aqui  imprime os valores que foram adicionados com sucesso..

                ExploreDict(dict);
            }
        }

        static void ExploreDict(Dictionary<string, string> dict)
        {
            Console.WriteLine("\n");
            Console.WriteLine(string.Join("; ", dict.Keys));
            Console.WriteLine(string.Join("; ", dict.Values));

            Console.WriteLine(dict.ContainsKey("04"));      
            Console.WriteLine(dict.ContainsValue("C#"));       

            Console.WriteLine(dict.Count);  
            
            dict.Remove("01");
            Console.WriteLine(string.Join("; ", dict));  

            dict.TryGetValue("02", out string valor);
            Console.WriteLine(valor);                        
        }
    }
}
