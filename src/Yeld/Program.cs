using System;
using System.Collections.Generic;

namespace Yeld
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizePage = 50;
            var db = new Repository();            
            int totalItens = db.Count();                  

            var content = new Content(); 
            content.Items = new List<int>();      
            content.TotalPages = totalItens /sizePage;   

            int currentPage = 1;                         

            foreach (var item in db.Get())
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


    public class Repository
    {
        private int[] list = new int[200];
        public Repository()
        {
            for (int i = 0; i < 200; i++)
            {
                list[i] = i;
            }
        }


        public int Count()
        {
            return list.Length;
        }


        public IEnumerable<int> Get()
        {
            //int[] list = new int[200];

            for (int i = 0; i < list.Length; i++)
            {
                //list[i] = i;
                yield return list[i];
            }

            // return list;
            
        }
        
    }


    public class Content
    {
        public List<int> Items { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }
}
