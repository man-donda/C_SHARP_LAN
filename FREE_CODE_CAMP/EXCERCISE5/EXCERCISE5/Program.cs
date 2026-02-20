using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                // Console.WriteLine(num + " X " + i + " = "+ num*i);
                Console.WriteLine("{0} X {1} = {2}", num, i , num*i);
            }
            Console.ReadLine();
        }
    }
}
