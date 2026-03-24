using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE20_VOID_FUNCTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            welcomeMessage();
            createAndPrintArray();
        }

        static void createAndPrintArray()
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5};
            foreach(int i in numbers)
            {
                Console.Write($"{i} ");
            }
        }

        static void welcomeMessage()
        {
            Console.WriteLine("Welcome to my program!");
        }
    }
}
