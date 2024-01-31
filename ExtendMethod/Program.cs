using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendMethod
{
       public static class TestClass
        {
            public static void TestMethodSquareNumber(this int x)
            {
            Console.WriteLine($"Your Number is {x*x}");
            }
        public static void TestMethodLowerCase(this string x)
        {
            Console.WriteLine($"Your String is {x.ToLower()}");
        }
    }
internal class Program
    {
        static void Main(string[] args)
        {
            TestClass.TestMethodSquareNumber(5);

            int z = 100;
            z.TestMethodSquareNumber();
            int y = 500;
            y.TestMethodSquareNumber();

            string name = "Farhan Mehedi";
            name.TestMethodLowerCase();

            Console.ReadKey();
        }
    }
}
