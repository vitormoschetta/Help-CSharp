using System;
using Delegate;

namespace delegado.Services
{
    public class Calculator   
    {
        public decimal Sum(decimal x, decimal y)
        {
            return x + y;
        }

        public decimal Subtract(decimal x, decimal y)
        {
            return x - y;
        }

        public decimal Multiply(decimal x, decimal y)
        {
            return x * y;
        }

        public decimal Divide(decimal x, decimal y)
        {
            return x / y;
        }

        public dynamic GenericCalc(dynamic x, dynamic y, char operation)
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