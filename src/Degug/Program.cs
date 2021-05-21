using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Degug
{
    public class Generic
    { }

    public class Quote : Generic
    {
        public string Number { get; set; }
    }

    public class QuoteItem : Generic
    {
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string QuoteNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string request01 = JsonSerializer.Serialize(new Quote() { Number = "001" });
            string request02 = JsonSerializer.Serialize(new QuoteItem() { ProductCode = "150", ProductDescription = "Product Xpto", QuoteNumber = "001" });
            
            var quote = JsonSerializer.Deserialize<Quote>(request01);
            var quoteItem = JsonSerializer.Deserialize<QuoteItem>(request02);
        }
    }    
}
