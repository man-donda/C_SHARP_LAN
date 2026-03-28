using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE28_SUM_OF_INT_ARRAY
{
    /*
    - Create and initialize an int array of numbers
    - Create function sumOfNumber with int return type
    - int array param
    - Function should return total of all numbers
    - Call in main and output the total
    - Extra: check array length
             return -1 if array is empty
             check return in main and output message
             do we need to return -1, how else we can make this?
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5
            };

            //int result = sumOfNumbers(numbers);

            //if (result > -1)
            //{
            //    Console.WriteLine($"The total is {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Cannot add up an empty Array!");
            //}

            if (sumOfNumbers(numbers, out int sum))
            {
                Console.WriteLine($"The total is {sum}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty Array!");
            }

            Console.ReadLine();
        }

        static bool sumOfNumbers(int[] numbers, out int sum)
        {
            sum = 0;

            if(numbers.Length > 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return true;
            }
            return false;
        }
    }
}