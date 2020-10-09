using System;
using System.Collections.Generic;
using MyBookLibrary;

namespace MyApp
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("\n---menu---");
            Console.WriteLine("1. Add new book");
            Console.WriteLine("2. Update a book");
            Console.WriteLine("3. Delete a book");
            Console.WriteLine("4. List all book");
            Console.WriteLine("5. Quit");
            Console.Write("Please choose one: ");
        }
        static void Main(string[] args)
        {
            bool stay = true;
            List<Book> ListBooks = new List<Book>();

            while (stay)
            {
                Menu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ManageBook.AddBook(ListBooks);
                        break;
                    case "2":
                        ManageBook.UpdateBookInfo(ListBooks);
                        break;
                    case "3":
                        ManageBook.DeleteBookInfo(ListBooks);
                        break;
                    case "4":
                        ManageBook.ListBooks(ListBooks);
                        break;
                    case "5":
                        Console.WriteLine("bye!");
                        stay = false;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
        }
    }
}
