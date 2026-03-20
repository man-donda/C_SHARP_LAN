using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE12_ARRAY_REVERSAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5
            };

            int[] sortedArray = new int[numbers.Length];
            int x = 0;

            //Array.Reverse(numbers);
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sortedArray[x] = numbers[i];
                x++;
            }

            foreach (int num in sortedArray)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
