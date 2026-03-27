using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE26_REFERENCE_PARAMETERS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Reference Parameter";

            //int num = 10;
            string name = "Joe";
            //assign(ref num, ref name);
            //Console.WriteLine(num); 
            //Console.WriteLine(name);

            int index = 0;
            int.TryParse("", out index);

            Console.Write("Enter your new name: ");
            string newName = Convert.ToString(Console.ReadLine());

            if(changeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}!");
            }
            else
            {
                Console.WriteLine("New name cannot be empty or null!");
            }   
        }

        static bool changeName(ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
            return false;
        }

        static void assign(ref int num, ref string name)
        {
            name = "Aba";
            num = 20;
        }
    }
}