using System;

namespace ConsoleApp2
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; } = String.Empty;
        public string Category { get; set; } = String.Empty;
        public decimal Price { get; set; }
    }
}