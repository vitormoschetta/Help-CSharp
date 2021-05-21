using System;
using System.Text.Json;

namespace _JSON
{
    public class QuoteItem
    {
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string QuoteNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string request = JsonSerializer.Serialize(new QuoteItem() { ProductCode = "150", ProductDescription = "Product Xpto", QuoteNumber = "001" });
            Console.WriteLine(request);  

            var quoteItem = JsonSerializer.Deserialize<QuoteItem>(request);         
        }
    }
}
