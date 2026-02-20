using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE6_STRING_FORMATING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Man";
            int age = 21;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine();
            
            Console.WriteLine("Name: "+name+"\nAge: "+age);
            Console.WriteLine();
           
            Console.WriteLine("Your Name is "+name+" and your Age is "+age);
            Console.WriteLine(); 
            
            Console.WriteLine("Your Name is {0} and your Age is {1}", name, age);
            Console.WriteLine() ;
            
            Console.WriteLine($"Your Name is {name} and your Age is {age}");
            Console.WriteLine();
           
            string test = string.Concat("Your Name is ", name, " and your Age is ", age);
            Console.WriteLine(test);
            Console.WriteLine();
            
            Console.WriteLine(string.Concat("Your Name is ", name, " and your Age is ", age));
            Console.WriteLine();
            
            Console.ReadLine();
        }
    }
}
