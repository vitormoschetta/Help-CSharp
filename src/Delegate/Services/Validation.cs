using System;
using Delegate.Models;

namespace Delegate.Services
{
    public class Validation 
    {
        public void Validate(Product item)
        {   
            if (item.Id == Guid.Empty)
                Console.WriteLine("Id inválido!");
            else
                Console.WriteLine("Id válido!");
        }
    }
}