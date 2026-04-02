using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCERCISE36_CLASS_VARIABLE_FUNCTION_SCOPE
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;
            private string test = "Hello";

            public Person(string name, int age)
            {
                Console.WriteLine(name);
                Console.WriteLine(this.name);   
                string test = "hi"; 
                Console.WriteLine(test);
            }

            public void setName(string name)
            {
                /*   if (!string.IsNullOrEmpty(name))
                   {
                       this.name = name;
                   }
                   else
                   {
                       this.name = "Invalid name";
                   }*/

                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
            }

            public string getName()
            {
                return name;
            }

            public void setAge(int age)
            {
                /*
                if(age >= 0 && age <= 150)
                {
                    this.age = age;
                }
                else
                {
                    this.age = -1;
                }
                */
                this.age = age >= 0 && age <= 150 ? age : -1;
            }

            public int getAge()
            {
                return age;
            }
            public string returnDetails()
            {
                string test = "";
                return $"Name: {name} \nAge: {age}";
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Class Variable/Function scope";

            Person person = new Person("Aba", 23);
            Console.WriteLine(person.returnDetails());

            Console.ReadLine();
        }
    }
}