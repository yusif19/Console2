using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAptek
{
    internal class Medicine
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public static int _count;
        public int Count { get; set; }
        public Medicine(string name, double price)
        {
            _count++;
            Count = _count;
            Name = name;
            Price = price;
            
        }
    }
}
