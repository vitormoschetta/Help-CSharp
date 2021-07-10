using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace _TaskT
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var html = await GetHtmlAsync();
            Console.WriteLine(html);

            ProcessoY();
            Console.ReadLine();
        }

        static async Task<string> GetHtmlAsync()
        {
            Console.WriteLine("\nIniciando GetHtml");

            string html = await new HttpClient().GetStringAsync("https://vitormoschetta.github.io/");
            return html;
        }

        static void ProcessoY()
        {
            Console.WriteLine("\nIniciando processo Y...");
            Console.WriteLine("\nFim do processo Y");
        }
    }
}
