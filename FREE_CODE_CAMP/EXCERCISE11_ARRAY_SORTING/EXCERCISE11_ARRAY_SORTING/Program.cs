using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE11_ARRAY_SORTING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1, 12, 3, 11, 5, 6, 17, 8, 15, 10
            };

            Array.Sort(numbers);

            foreach (int num in numbers)
            {
               Console.Write($"{num} ");
            }                      
        }
    }
}
