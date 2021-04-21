using System;
using System.Collections.Generic;

namespace _Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizePage = 50;
            var repository = new Repository();            
            int totalItens = repository.Count();                  

            var content = new Content(); 
            content.Items = new List<int>();      
            content.TotalPages = totalItens /sizePage;   

            int currentPage = 1;                         


            // Podemos usar tanto o repository.Get01 quanto o Get02.
            // A diferença é que o Get02 utiliza 'yield return', retornando os dados 
            // linha a linha a medida que vão ficando disponíveis, ganhando em performance, 
            // pois não deixa serviços ociosos.            
            foreach (var item in repository.Get02())
            {                
                content.Items.Add(item);                

                if (content.Items.Count >= sizePage) 
                {
                    content.CurrentPage = currentPage;                       
                    Send(content);  
                    content.Items.Clear();
                    currentPage++;
                }                     
            }
        }


        public static void Send(Content content)
        {
            Console.WriteLine($"Current Page: {content.CurrentPage}");

            foreach (var item in content.Items)
            {                
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");
        }
    
    }    
    
}
