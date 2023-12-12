using System;

namespace ConsoleApp2
{
    public class Order
    {
        public int Id { get; set; }
        public string name { get; set; } = String.Empty;
        public string Category { get; set; } = String.Empty;
        public decimal Price { get; set; }
    }
}