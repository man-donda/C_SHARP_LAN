using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EXCERCISE33_STRUCTURE
{
    internal class Program
    {
        struct Person
        {
            public string name;
            public int age;
            public int birthmonth;
            public int number;
            public Person(string name, int age, int birthmonth, int number)
            {
                this.name = name;
                this.age = age;
                this.birthmonth = birthmonth;
                this.number = number;  
            }
        }
        static void Main(string[] args)
        {
            /*
            string name = "Aba";
            int age = 23;
            int birthmonth = 5;

            Person person;

            person.name = "Aba";
            person.age = 23;

            Console.WriteLine($"{person.name} - {person.age} - {birthmonth}");

            string newName = "";
            int newAge = 0;
            int newBirthmonth = 0;
            returnPerson( ref newName, ref newAge, ref newBirthmonth);
            Console.WriteLine($"{newName} - {newAge} - {newBirthmonth}");
        */

            Person person = returnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthmonth} - {person.number}");

            Console.ReadLine();
        }

        static Person returnPerson()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birthmonth: ");
            int birthmonth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            /*
            Person person;
            
            person.name = name;
            person.age = age;
            person.birthmonth = birthmonth;
            person.number = number;

            return person;*/

            return new Person(name, age, birthmonth, number);
        }

        /*static void  returnPerson( ref string name, ref int age, ref int birthmonth)
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birthmonth: ");
            birthmonth = Convert.ToInt32(Console.ReadLine());
        
        }*/
    }
}
