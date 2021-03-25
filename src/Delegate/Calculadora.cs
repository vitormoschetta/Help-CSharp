namespace delegado
{
    public class Calculadora
    {
        public static decimal Somar(decimal x, decimal y)
        {
            return x + y;
        }

        public static decimal Subtrair(decimal x, decimal y)
        {
            return x - y;
        }

        public static decimal Multiplicar(decimal x, decimal y)
        {
            return x * y;
        }

        public static decimal Dividir(decimal x, decimal y)
        {
            return x / y;
        }
    }

    public delegate decimal DelCalc(decimal x, decimal y);
}