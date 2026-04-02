using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE37_CLASS_PROPERTIES
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age;

        Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Name = name;
        }


        public string returnDetails()
        {
            return $"Name: {name} \nAge: {age}";
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Person person = new Person("Aba", 23);
                Console.WriteLine(person.returnDetails());

                person.Name = "Harry";

                Console.WriteLine(person.returnDetails());

                Console.WriteLine($"Your name is {person.Name}");

            }
        }
    }
}
