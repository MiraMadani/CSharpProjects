using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework2
{
    internal class Last
    {
        public static void Main()
        {
            var arr = File.ReadAllLines(@"C:\Test\1.txt");
            arr = arr.Select(arr => arr.ToUpperCase()).ToArray();
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    public static class Extansions
    {
        public static string ToUpperCase(this string a)
        {
            return string.Concat(a[0].ToString().ToUpper(), a.AsSpan(1));
        }
    }
}
