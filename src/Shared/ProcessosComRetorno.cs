namespace Shared
{
    public class ProcessosComRetorno
    {
        public static string ProcessoA()
        {
            for (long i = 0; i < 900000000; i++)
            {

            }
            return "Processo A concluído!";
        }

        public static string ProcessoB()
        {
            for (long i = 0; i < 900000000; i++)
            {

            }
            return "Processo B concluído!";
        }

        public static string ProcessoC()
        {
            for (long i = 0; i < 900000000; i++)
            {

            }
            return "Processo C concluído!";
        }
    }
}