using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE23_OPTIONAL_PARAMETER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = add(5);
            Console.WriteLine(result);
        }

        static int add(int a, int b = 50)
        {
            return a + b;
        }
    }
}
