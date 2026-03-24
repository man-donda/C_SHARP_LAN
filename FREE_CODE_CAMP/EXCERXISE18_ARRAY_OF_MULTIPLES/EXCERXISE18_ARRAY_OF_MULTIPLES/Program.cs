using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERXISE18_ARRAY_OF_MULTIPLES
{
    internal class Program
    {
        /*
         - Define and initialise two integers (num, length)
         - (7, 5) -> [ 7, 14, 21, 28, 35]
         - Create int array with suze length
         - Loop through and insert the (loop counter x num) into the array
         - Print the final Array.
        */
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Length: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int[] result = new int[size];
                   
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = num * (i+1);
            }

            foreach(int item in result)
            {
                Console.Write($"- {item} ");
            }

            Console.ReadLine();
        }
    }
}
