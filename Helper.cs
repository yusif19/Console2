using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAptek
{
    public static class Helper
    {
        public static string Capitalize(this string str)
        {
            return $"{Char.ToUpper(str[0])}{str.Substring(1).ToLower()}";
        }     
    }
}
