using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE32_CUSTOM_TRYPARSE
{
    internal class Program
    {
        /*
        - Create a int and try convert any string to an int
        - Notice the error, write a try...catch handler around it
        - Catch the error and output the error message
        - Without changing the current code
        -
        - Why is this a bad situation and how can we know if its been converted?
        -
        - Create a custom try parse function
        - Find the real function and copy return type/params
        - Read the tooltip it gives you, to give you ideas on what to do
        */
        static void Main(string[] args)
        {
            /*
            bool success = false;
            try
            {
                Console.Write("Enter the number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                success = true;
            } 
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(success ? "Yey" : "Oh no");
            */

            Console.Write("Enter a number: ");
            if(tryParse(Console.ReadLine(),out int result))
            {
                Console.WriteLine("Yay " + result);
            }
            else
            {
                Console.WriteLine("Oh, no");
            }

            Console.ReadLine();
        }

        static bool tryParse(string input, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch(Exception)
            {
                return false;                
            }
        }
    }
}