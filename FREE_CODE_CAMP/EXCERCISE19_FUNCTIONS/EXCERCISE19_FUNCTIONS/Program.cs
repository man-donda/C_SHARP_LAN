using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE19_FUNCTIONS
{
    class Test
    {
        public static void something()
        {
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test.something();

            welcomeMessage();
            Console.ReadLine();
        }

        static void welcomeMessage()
        {
            Console.WriteLine("Hello World");
        }
    }
}
