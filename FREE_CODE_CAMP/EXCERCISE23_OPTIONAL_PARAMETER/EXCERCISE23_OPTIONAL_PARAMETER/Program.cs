using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE23_OPTIONAL_PARAMETER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = $"Optional Parameter";

            int result = add(5);
            Console.WriteLine(result);

            printName("Joe");
            Console.ReadLine();
        }
            
        static void printName(string name = "Aba")
        {
            Console.WriteLine($"My name is {name}");
        }

        static int add(int a, int b = default)
        {
            Console.WriteLine($"b is {b}");
            return a + b;
        }
    }
}