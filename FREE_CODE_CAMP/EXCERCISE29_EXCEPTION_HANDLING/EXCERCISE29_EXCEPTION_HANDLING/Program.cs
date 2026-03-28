using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE29_EXCEPTION_HANDLING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exception Handling";

            Console.Write("Enter number: ");
            int num =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Entered number is {num}");
        }
    }
}
