using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegexUser
{
    // Trabalhar com localização de textos e identificação de sequencias de texto
    public class Exemplos
    {       
        private List<string> frases;
        public Exemplos()
        {
            frases = new List<string>();
            frases.Add("eu não quero");
            frases.Add("Quero sim");
            frases.Add("nao quero mais");
        }
        public void ProcurarOcorrenciaDeTextos02()
        {
            // procurar em uma lista de frases as que contenham o texto 'nao'
            Regex ER = new Regex("nao");           

            for (int i = 0; i < frases.Count; i++)
            {
                if (ER.IsMatch(frases[i]))
                    Console.WriteLine(frases[i]);
            }
            Console.WriteLine("\n");
        }

        public void ProcurarOcorrenciaDeTextos03()
        {
            // procurar em uma lista de frases as que contenham o texto 'nao' ou 'não
            Regex ER = new Regex("n[aã]o");          

            for (int i = 0; i < frases.Count; i++)
            {
                if (ER.IsMatch(frases[i]))
                    Console.WriteLine(frases[i]);
            }
            Console.WriteLine("\n");
        }

        public void ProcurarOcorrenciaDeTextos04()
        {
            // procurar em uma lista de frases as que iniciam com a palavra 'Quero'
            Regex ER = new Regex("^Quero");          

            for (int i = 0; i < frases.Count; i++)
            {
                if (ER.IsMatch(frases[i]))
                    Console.WriteLine(frases[i]);
            }
            Console.WriteLine("\n");
        }

        public void ProcurarOcorrenciaDeTextos05()
        {
            // procurar em uma lista de frases as que iniciam com a palavra 'Quero' ou 'quero
            Regex ER = new Regex("^[Qq]uero"); 

            for (int i = 0; i < frases.Count; i++)
            {
                if (ER.IsMatch(frases[i]))
                    Console.WriteLine(frases[i]);
            }
            Console.WriteLine("\n");           
        }

        public void ProcurarOcorrenciaDeTextos06()
        {
            // mesma coisa que o anterior, porém ao invés de [Qq] usamos 'IgnoreCase'
            Regex ER = new Regex("^quero", RegexOptions.IgnoreCase); // ignoreCase informa que independe de maiúscula ou minúscula           

            for (int i = 0; i < frases.Count; i++)
            {
                if (ER.IsMatch(frases[i]))
                    Console.WriteLine(frases[i]);
            }
            Console.WriteLine("\n");
        }

        public void ProcurarOcorrenciaDeTextos07()
        {
            // procurar em uma lista de frases as que terminam com a palavra 'quero'
            Regex ER = new Regex("quero$");           

            for (int i = 0; i < frases.Count; i++)
            {
                if (ER.IsMatch(frases[i]))
                    Console.WriteLine(frases[i]);
            }
            Console.WriteLine("\n");
        }

        public void ProcurarOcorrenciaDeTextos08()
        {
            var texto = "Supermercado Irmãos Gonçalves";
            Regex ER = new Regex("(mini|(su|hi)per)mercado", RegexOptions.IgnoreCase);    
            // Esse regex é válido para as palavras a baixo:
            //Minimercado, minimercado, Supermercado, supermercado, hipermercado, Hipermercado       

            if (ER.IsMatch(texto))
                Console.WriteLine(texto);

            Console.WriteLine("\n");
        }

        public void ProcurarOcorrenciaDeTextos09()
        {
            var texto = " nao quero mais isso";
            Regex ER = new Regex(@"(\s)n[aã]o", RegexOptions.IgnoreCase);        
            // identifica frase iniciada com ESPAÇO então seguido do texo 'Não/não'     

            if (ER.IsMatch(texto))
                Console.WriteLine(texto);

            Console.WriteLine("\n");
        }

        public void ProcurarOcorrenciaDeTextos10()
        {
            var texto = " nao quero mais isso";
            Regex ER = new Regex(@"^(\sn[aã]o)|^(n[aã]o)");        
            // identifica frase iniciada com 'Não/não' ou ESPAÇO seguido de 'Não/não'  

            if (ER.IsMatch(texto))
                Console.WriteLine(texto);

            Console.WriteLine("\n");
        }


    }
}