using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE37_CLASS_PROPERTIES
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //public string Name { get => name; set => name = value; }
        //public int Age { get => age; set => age = value; }

        /*
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = !string.IsNullOrEmpty(value) ? value : "Invalid name";
            }
        }

        public int Age
        {
            get
            {
                return age; 
            }
            set
            {
               age = value >= 0 && value <= 150 ? value : -1;
            }
        }*/
        
        /*
        public string name
        {
            get => name;
            set => name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
        }

        public int age
        {
            get => age;
            set => age = value >= 0 && value <= 150 ? value : -1;
        }*/
                
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string returnDetails()
        {
            return $"Name: {Name} \nAge: {Age}";
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Person person = new Person("Aba", 23);
                Console.WriteLine(person.returnDetails());

                person.Name = "Harry";
                person.Age = 25;

                //Console.WriteLine(person.returnDetails());

                Console.WriteLine($"Your name is {person.Name} and age is {person.Age}");

                Console.ReadLine();
            }
        }
    }
}