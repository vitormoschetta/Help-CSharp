using System;
using System.Text.Json;

namespace _JSON
{
    public class QuoteItem
    {
        public QuoteItem(string productCode, string productDescription, string quoteNumber)
        {
            ProductCode = productCode;
            ProductDescription= productDescription;
            QuoteNumber = quoteNumber;
        }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string QuoteNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string requestMock = Serialize();
                    
            var quoteItem = Deserialize(requestMock);
            
            PrintPropertys(quoteItem);            
        }


        static string Serialize()
        {
            var quoteItem = new QuoteItem("150", "Product Xpto", "001");
            var serialized = JsonSerializer.Serialize(quoteItem);    
            Console.WriteLine(serialized);
            return serialized;                    
        }

        static QuoteItem Deserialize(string requestMock)
        {
            return JsonSerializer.Deserialize<QuoteItem>(requestMock);
        }

        static void PrintPropertys(QuoteItem quoteItem)
        {
            Console.WriteLine("\n");

            var props = quoteItem.GetType().GetProperties();
            foreach (var prop in props)
            {                
                Console.WriteLine($"{prop.Name} = {prop.GetValue(quoteItem, null)}");
            }
        }
    }
}
