using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE35_CLASS_FIELDS
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public void setName(string name)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    this.name = name;
                }
                else
                {
                    this.name = string.Empty;
                }
            }

            public string returnDetails()
            {
                return $"Name: {name} \nAge: {age}";
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Aba", 23);
            Console.WriteLine(person.returnDetails());

            //person.name = "Harry";
            //person.age = 23;
            person.setName("Harry");
            Console.WriteLine(person.returnDetails());

            Console.ReadLine();
        }
    }
}
