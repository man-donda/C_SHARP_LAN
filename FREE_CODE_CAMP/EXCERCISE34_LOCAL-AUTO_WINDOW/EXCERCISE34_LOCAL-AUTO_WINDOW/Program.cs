using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE34_LOCAL_AUTO_WINDOW
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string name = "Aba";
            int age = 23;

            printDetails(name, age);

            string message = readFromConsole("Enter anything: ");
            Console.WriteLine(message);

            Console.ReadLine();
        }

        static string readFromConsole(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        static void printDetails(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
        }     
    }
}
