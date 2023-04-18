using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAptek
{
    internal class Category
    {
        public string Name { get; set; }
        public static int _id;
        public int Id { get; set; }
        

        public Category(string name)
        {
            _id++;
            Id = _id;
            Name = name.Capitalize();
        }
    }
}
