using System;
using System.Text.Json;

namespace _BinaryUTF8
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
            byte[] jsonUtf8Bytes;
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(new QuoteItem() { ProductCode = "150", ProductDescription = "Product Xpto", QuoteNumber = "001" });
            Console.WriteLine(jsonUtf8Bytes);
        }
    }
}
