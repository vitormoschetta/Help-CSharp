using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _Regex
{
    // Trabalhar com números e/ou localização de números
    public class Exemplos02
    {
        private string texto;
        public Exemplos02()
        {
            texto = "Vitor, 31 anos";
        }
        public void ProcurarOcorrenciaDeTextos()
        {
            Regex regex = new Regex("[0-9]");
            // aqui vamos apenas mostrar a frase caso ela contenha algum caractere númerico

            if (regex.IsMatch(texto))
                Console.WriteLine(texto);

            Console.WriteLine("\n");
        }

        public void ProcurarOcorrenciaDeTextos02()
        {
            Regex regex = new Regex("[0-9]");
            // aqui vamos mostrar o caractere numerico encontrado, porém, dessa forma vai mostrar o primeiro numero encontrado
            Match match = regex.Match(texto);
            if (match.Success)
                Console.WriteLine(match.Value);

            Console.WriteLine("\n");
        }

        public void ProcurarOcorrenciaDeTextos03()
        {
            Regex regex = new Regex("[0-9]+");
            // dessa forma vai mostrar todos os caracteres numericos encontrado, seu tamanho e local/indice 
            Match match = regex.Match(texto);
            if (match.Success)
                Console.WriteLine("Números encontrados: " + match.Value + 
                                "; Posição na frase: " + match.Index +
                                "; Quantidade: " + match.Length);

            Console.WriteLine("\n");
        }

        public void ProcurarOcorrenciaDeTextos04()
        {
            Regex regex = new Regex(@"^[^,]+,\s[0-9]+");
            // Procura todo o texto do início, que NÃO seja uma vírgula + uma vírgula + ESPAÇO + sequencia numérica            
            Match match = regex.Match(texto);
            if (match.Success)
                Console.WriteLine(match.Value);                               

            Console.WriteLine("\n");
        }

        public void ProcurarOcorrenciaDeTextos05()
        {
            Regex regex = new Regex(@"^([^,]+),\s([0-9]+)");
            // Mesma busca do exemplo anterior, porém com grupos separados por PARENTESIS            
            Match match = regex.Match(texto);
            if (match.Success)
                Console.WriteLine("Texto localizado: " + match.Groups[0].Value + " \n" + 
                                "Grupo 01: " + match.Groups[1] + "\n" +
                                "Grupo 02: " + match.Groups[2]);

            Console.WriteLine("\n");
        }

        public void ProcurarOcorrenciaDeTextos06()
        {
            Regex regex = new Regex(@"^(?<nome>[^,]+),\s(?<idade>[0-9]+)");
            // Mesma busca do exemplo anterior, porém com grupos NOMEADOS         
            Match match = regex.Match(texto);
            if (match.Success)
                Console.WriteLine("Grupo 01: " + match.Groups["nome"] + "\n" +
                                "Grupo 02: " + match.Groups["idade"]);

            Console.WriteLine("\n");
        }

        public void ProcurarOcorrenciaDeTextos07()
        {
            // MatchCollection 
            texto = "123-456-789-0";
            Regex regex = new Regex(@"([0-9]+)");
            MatchCollection matchCollection = regex.Matches(texto);

            foreach (var item in matchCollection)
                Console.WriteLine(item);
                       
            Console.WriteLine("\n");
        }


    }
}