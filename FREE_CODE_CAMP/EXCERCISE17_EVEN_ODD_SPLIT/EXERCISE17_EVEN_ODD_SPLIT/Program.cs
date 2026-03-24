using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE17_EVEN_ODD_SPLIT
{
    internal class Program
    {
        /*
         - Create two lists with integer datatype, one for even numbers, one for odd. 
         - Loop from 0-20 
           - if number is even, add to even list.
           - if number is odd, add to odd list.
        - Print even list
        - Print odd list
        */

        static void Main(string[] args)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for(int i = 0; i <= 20; i++)
            {
                if(i % 2 == 0)
                {
                    even.Add(i);    
                }
                else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine("Printing even items: ");

            foreach(int value in even)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine();
            Console.WriteLine(Environment.NewLine + "Printing odd items: ");

            foreach(int value in odd)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine();
        }
    }
}
