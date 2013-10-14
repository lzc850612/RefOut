using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1 { a = 123, b = 456 };
            Test(ref a);
            Console.Write(a.a);
            Console.Read();
        }

        private static void Test(ref Class1 input)
        {
            input = new Class1();
            input.a = 234;
            Console.Write(input.a);
        }
    }

    public class Class1
    {
        public int a { get; set; }
        public int b { get; set; }
    }
}