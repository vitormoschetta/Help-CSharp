using System;

namespace IntervaloTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void RepresentacaoTimeSpan()
        {
            /*  [ - ]d.HH:mm:SS.FF
                onde:
                [ - ] negativo é opcional
                d --> dias
                HH --> horas
                mm --> minutos
                SS --> segundos
                FF --> milésimo de segundos
            */

            string representacao = "5.12:30:59.100";
            TimeSpan time = TimeSpan.Parse(representacao);
            Console.WriteLine(time);
        }


        static void MostraDiferencaEntreDuasDatas()
        {
            DateTime date1 = new DateTime(2021, 3, 25, 8, 30, 0);
            DateTime date2 = new DateTime(2021, 3, 25, 8, 30, 0);

            TimeSpan interval = date2 - date1;

            Console.WriteLine("Primeira marcação: {0}; Segunda marcação: {1};", date1, date2);
            Console.WriteLine("Intervalo de tempo: " + interval);
        }

        static void VerificaDiferencaZero()
        {
            DateTime date1 = new DateTime(2021, 3, 25, 8, 30, 0);
            DateTime date2 = new DateTime(2021, 3, 25, 8, 30, 0);

            TimeSpan interval = date2 - date1;

            if (interval == TimeSpan.Zero)
                Console.WriteLine("Não há diferença entre as duas datas");
            else
                Console.WriteLine("Diferença entre as datas:" + interval);
        }

        static void AdicionaTempoAoTimeSpanExistente()
        {
            TimeSpan time = new TimeSpan(2, 5, 39);
            Console.WriteLine(time.Add(new TimeSpan(1,0,0)));
        }
        static void RemoveTempoDoTimeSpanExistente()
        {
            TimeSpan time = new TimeSpan(2, 5, 39);
            Console.WriteLine(time.Subtract(new TimeSpan(1,0,0)));
        }

        static void TempoNegativo()
        {
            TimeSpan time = new TimeSpan(2, 5, 39);
            Console.WriteLine(time.Negate());
        }


        static void InicializaTimeSpan()
        {
            TimeSpan time = new TimeSpan();
            Console.WriteLine(time);
        }
        // ou:
        static void InicializaTimeSpanZero()
        {
            TimeSpan time = TimeSpan.Zero;
            Console.WriteLine(time);
        }

        static void InicializaTimeSpanComTempo()
        {
            TimeSpan time = new TimeSpan(2, 5, 39);
            Console.WriteLine(time);
        }

        static void ConverteStringParaTimeSpan()
        {
            string tempo = "10:12:59";
            TimeSpan time = TimeSpan.Parse(tempo);
            Console.WriteLine(time);
        }

        static void ConverteStringParaData()
        {
            string valor = "1989, 5, 28";
            DateTime data = DateTime.Parse(valor);
            Console.WriteLine(data);
        }

    }
}
