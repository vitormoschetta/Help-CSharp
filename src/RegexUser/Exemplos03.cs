using System;
using System.Text.RegularExpressions;

namespace RegexUser
{
    public class Exemplos03
    {
        public void ExemploA()
        {
            var texto = "   Aw";
            Regex regex = new Regex("[Aw]+");            
            Match match = regex.Match(texto);
            if (match.Success)
                Console.WriteLine(match.Value);

            Console.WriteLine("\n");
        }
    }
}