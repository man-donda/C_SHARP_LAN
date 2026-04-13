using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_PROJECT03
{
    class Student
    {
        public int Id;
        public string Name;
        public int Marks;
        public string Grade;
    }
    internal class Program
    {
        static string filePath = "students.txt";
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Student Record System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddStudent(); break;
                    case 2: ViewStudents(); break;
                    case 3: SearchStudent(); break;
                    case 4: UpdateStudent(); break;
                    case 5: DeleteStudent(); break;
                    case 6: Console.WriteLine("Exiting..."); break;
                    default: Console.WriteLine("Invalid choice!"); break;
                }

            } while (choice != 6);
        }

        static string CalculateGrade(int marks)
        {
            if (marks >= 80) return "A";
            else if (marks >= 60) return "B";
            else if (marks >= 40) return "C";
            else return "F";
        }

        static void AddStudent()
        {
            Student s = new Student();

            Console.Write("Enter ID: ");
            s.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Marks: ");
            s.Marks = Convert.ToInt32(Console.ReadLine());

            s.Grade = CalculateGrade(s.Marks);

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{s.Id},{s.Name},{s.Marks},{s.Grade}");
            }

            Console.WriteLine("Student Added!");
        }

        static void ViewStudents()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No records found!");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("\n--- Student List ---");
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                Console.WriteLine($"ID: {data[0]} | Name: {data[1]} | Marks: {data[2]} | Grade: {data[3]}");
            }
        }

        static void SearchStudent()
        {
            Console.Write("Enter ID to search: ");
            string id = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("No records found!");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            bool found = false;

            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                if (data[0] == id)
                {
                    Console.WriteLine($"Found -> ID: {data[0]} | Name: {data[1]} | Marks: {data[2]} | Grade: {data[3]}");
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Student not found!");
        }

        static void UpdateStudent()
        {
            Console.Write("Enter ID to update: ");
            string id = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("No records found!");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            bool found = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                if (data[0] == id)
                {
                    Console.Write("Enter new Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter new Marks: ");
                    int marks = Convert.ToInt32(Console.ReadLine());

                    string grade = CalculateGrade(marks);

                    lines[i] = $"{id},{name},{marks},{grade}";
                    found = true;
                    break;
                }
            }

            if (found)
            {
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Student Updated!");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        static void DeleteStudent()
        {
            Console.Write("Enter ID to delete: ");
            string id = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("No records found!");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            bool found = false;

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');

                    if (data[0] != id)
                    {
                        sw.WriteLine(line);
                    }
                    else
                    {
                        found = true;
                    }
                }
            }

            if (found)
                Console.WriteLine("Student Deleted!");
            else
                Console.WriteLine("Student not found!");
        }
    }
}
