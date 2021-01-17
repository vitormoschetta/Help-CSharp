using System;
using System.Text.RegularExpressions;

namespace RegexUser
{
    // Reconhecimento de letras
    public class Estudo01
    {
        public void Exercicio01()   // <-- Verificar a ocorrência da letra 'c' no texto
        {
            var texto = "abcde";
            Regex regex = new Regex(@"c");
            if (regex.IsMatch(texto))
                Console.WriteLine("O texto '" + texto + "' possui a letra 'c'");
        }

        public void Exercicio011()   // <-- Caracteres especiais: $ ^ * ( ) + { } [ ] \ | ? - .
        {
            // Para identificar um desses caracteres no texto é necessário colocar '\' antes
        
            var texto = "2*2=4";
            Regex regex = new Regex(@"2\*2=4");
            if (regex.IsMatch(texto))
                Console.WriteLine("O texto '" + texto + "' possui a letra 'c'");
        }

        public void Exercicio02()   // <-- Verificar a ocorrência de letra no INICIO do texto
        {
            var texto = "abcde";
            Regex regex01 = new Regex(@"^c");
            Regex regex02 = new Regex(@"^a");
            if (regex01.IsMatch(texto))
                Console.WriteLine("O texto '" + texto + "' possui a letra 'c' no início");
            else
                Console.WriteLine("O texto '" + texto + "' NÃO possui a letra 'c' no início");

            if (regex02.IsMatch(texto))
                Console.WriteLine("O texto '" + texto + "' possui a letra 'a' no início");
            else
                Console.WriteLine("O texto '" + texto + "' NÃO possui a letra 'a' no início");
        }

        public void Exercicio03()   // <-- Verificar a ocorrência de letra no FIM do texto
        {
            var texto = "abcde";
            Regex regex01 = new Regex(@"e$");            
            if (regex01.IsMatch(texto))
                Console.WriteLine("O texto '" + texto + "' possui a letra 'e' no FIM");            
        }

        public void Exercicio04()   // <-- Caracteres especiais
        {
            var texto = "bbcde";
            Regex regex01 = new Regex(@"[^a][e$]");            
            if (regex01.IsMatch(texto))
                Console.WriteLine("O texto '" + texto + "' possui a letra 'a' no INÍCIO e a letra 'e' no FIM");            
        }

        
    }
}