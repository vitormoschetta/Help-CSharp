using System;
using System.Text.Json;

namespace _BinaryUTF8
{
    public class QuoteItem
    {
        public QuoteItem(string productCode, string productDescription, string quoteNumber)
        {
            ProductCode = productCode;
            ProductDescription = productDescription;
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
            byte[] jsonUtf8Bytes;
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(new QuoteItem("150", "Product Xpto", "001"));


            var readOnlySpan = new ReadOnlySpan<byte>(jsonUtf8Bytes);
            var quoteItem = JsonSerializer.Deserialize<QuoteItem>(readOnlySpan);


        }
    }
}
