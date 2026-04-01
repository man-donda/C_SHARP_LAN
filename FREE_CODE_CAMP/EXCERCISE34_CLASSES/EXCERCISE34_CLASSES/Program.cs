using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE34_CLASSES
{
    internal class Program
    {
        /*
        struct Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        */

        class Person
        {
            public string name;
            public int age;

            public Person()
            {
            }
            public Person(string name)
            {
                this.name = name;
            }
            public Person(int age)
            {
                this.age = age;
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string returnDetails()
            {
                return $"Name: {name} \nAge: {age}";
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Classes";

            Person person = new Person();
            Console.WriteLine($"class person: {person.name} - {person.age}");
            
            Person person1 = new Person("Aba");
            Console.WriteLine($"class person1: {person1.name} - {person1.age}");
            
            Person person2 = new Person( 23);
            Console.WriteLine($"class person2: {person2.name} - {person2.age}");
            
            Person person3 = new Person("Aba", 23);
            Console.WriteLine($"class person3: {person3.name} - {person3.age}");

            //---------------------------------------------------------------------------------

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Person person4 = new Person(name, age);

            if (!string.IsNullOrEmpty(person4.name))
            {
                Console.WriteLine(person4.name);
            }

            if(person4.age > -1)
            {
                Console.WriteLine(person4.age);
            }
            
//-------------------------------------------------------------------------

            Person person5 = new Person("Aba", 23);
            //Console.WriteLine($"Name: {person5.name} \nAge: {person5.age}");
            //Console.WriteLine(person5);
            Console.WriteLine(person5.returnDetails());

            Console.ReadLine();
        }        
    }
}    