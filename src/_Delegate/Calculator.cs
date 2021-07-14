namespace _Delegate
{
    public class Calculator
    {
        public decimal GenericCalc(decimal x, decimal y, char operation)
        {
            switch (operation)
            {
                case '+':
                    return x + y;
                case '-':
                    return x - y;
                case '*':
                    return x * y;
                case '/':
                    return x / y;
                default:
                    return x + y;
            }
        }
    }
}