using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY_PROJECT02
{
    class Book
    {
        public int Id;
        public string Name;
        public bool IsIssued;

        public Book(int id, string name, bool isIssued = false)
        {
            Id = id;
            Name = name;
            IsIssued = isIssued;
        }
    }
    internal class Program
    {
        static List<Book> books = new List<Book>();
        static string filePath = "books.txt";
        static void Main(string[] args)
        {
            LoadBooks();

            while (true)
            {
                Console.WriteLine("\n===== Library Management System =====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View Books");
                Console.WriteLine("3. Search Book");
                Console.WriteLine("4. Issue Book");
                Console.WriteLine("5. Return Book");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddBook(); break;
                    case 2: ViewBooks(); break;
                    case 3: SearchBook(); break;
                    case 4: IssueBook(); break;
                    case 5: ReturnBook(); break;
                    case 6:
                        SaveBooks();
                        Console.WriteLine("Data saved. Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void AddBook()
        {
            Console.Write("Enter Book ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Name: ");
            string name = Console.ReadLine();

            books.Add(new Book(id, name));
            Console.WriteLine("Book added successfully!");
        }

        static void ViewBooks()
        {
            Console.WriteLine("\n--- Book List ---");
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.Id} | Name: {book.Name} | Issued: {book.IsIssued}");
            }
        }

        static void SearchBook()
        {
            Console.Write("Enter Book ID or Name: ");
            string input = Console.ReadLine();

            foreach (var book in books)
            {
                if (book.Id.ToString() == input || book.Name.ToLower() == input.ToLower())
                {
                    Console.WriteLine($"Found -> ID: {book.Id} | Name: {book.Name} | Issued: {book.IsIssued}");
                    return;
                }
            }
            Console.WriteLine("Book not found!");
        }

        static void IssueBook()
        {
            Console.Write("Enter Book ID to issue: ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (var book in books)
            {
                if (book.Id == id)
                {
                    if (!book.IsIssued)
                    {
                        book.IsIssued = true;
                        Console.WriteLine("Book issued successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Book already issued!");
                    }
                    return;
                }
            }
            Console.WriteLine("Book not found!");
        }

        static void ReturnBook()
        {
            Console.Write("Enter Book ID to return: ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (var book in books)
            {
                if (book.Id == id)
                {
                    if (book.IsIssued)
                    {
                        book.IsIssued = false;
                        Console.WriteLine("Book returned successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Book was not issued!");
                    }
                    return;
                }
            }
            Console.WriteLine("Book not found!");
        }

        static void SaveBooks()
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    sw.WriteLine($"{book.Id},{book.Name},{book.IsIssued}");
                }
            }
        }

        static void LoadBooks()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    string[] data = line.Split(',');
                    books.Add(new Book(
                        Convert.ToInt32(data[0]),
                        data[1],
                        Convert.ToBoolean(data[2])
                    ));
                }
            }
        }
    }
}
