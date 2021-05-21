using System;

namespace _Casting
{
    public class Operation
    { }

    public class Customer : Operation
    {
        public Customer()
        {
            Name = "Customer A";
            Email = "customera@emai.com";
        }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Product : Operation
    {
        public Product()
        {
            Id = Guid.NewGuid();
            Name = "Product A";
            Price = 5.5m;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var operation = new Operation();            
            var product = new Operation() as Product;
            var customer = (Customer)new Operation();
        }
    }
}
