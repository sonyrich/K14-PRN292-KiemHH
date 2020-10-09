using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace MyBookLibrary
{
    public class ManageBook
    {
        public static void ListBooks(List<Book> ListBooks)
        {
            Console.WriteLine("\n---Book List---");
            if (ListBooks.Any() != true)
            {
                Console.WriteLine("Nothing in the list!");
            }
            foreach (var item in ListBooks)
            {
                item.ExtractInfo();
            }
            Console.WriteLine("Press anykey to continue");
            Console.ReadKey();
        }

        public static void AddBook(List<Book> ListBooks)
        {
            if (ListBooks.Count > 100)
            {
                Console.WriteLine("The List is full! Can't add more");
            }
            else
            {
                Console.WriteLine("\n---Add Book---");
            InputID:
                Console.Write("Book ID: ");
                string ID = Console.ReadLine();

                foreach (var item in ListBooks)
                {
                    if (ID.Equals(item.ID))
                    {
                        Console.WriteLine("Book ID have been existed. Try again!");
                        goto InputID;
                    }
                }

                Console.Write("Title: ");
                string Title = Console.ReadLine();

                Console.Write("Author: ");
                string Author = Console.ReadLine();

            InputPrice:
                Console.Write("Price: ");
                float Price = float.Parse(Console.ReadLine());

                if (Price <= 0)
                {
                    Console.WriteLine("Price must be higher than 0!");
                    goto InputPrice;
                }

                ListBooks.Add(new Book(ID, Title, Author, Price));
                Console.WriteLine("Add successfully!");
            }
        }

        public static void UpdateBookInfo(List<Book> ListBooks)
        {
            bool check = false;
            Console.WriteLine("\n--- Update Book Info---");
            Console.Write("Input book ID ");
            string ID = Console.ReadLine();

            foreach (var item in ListBooks)
            {
                if (ID.Equals(item.ID))
                {
                    Console.Write("New Title: ");
                    item.ID = Console.ReadLine();
                }

                Console.Write("Title: ");
                item.Title = Console.ReadLine();

                Console.Write("Author: ");
                item.Author = Console.ReadLine();

            InputPrice:
                Console.Write("Price: ");
                float Price = float.Parse(Console.ReadLine());

                if (Price <= 0)
                {
                    Console.WriteLine("Price must be higher than 0!");
                    goto InputPrice;
                }
                item.Price = Price;
                Console.WriteLine("Updated successfully!");
                check = true;
            }
            if (!check)
            {
                Console.WriteLine("This book ID isn't existed!");
            }
        }

        public static void DeleteBookInfo(List<Book> ListBooks)
        {
            Boolean check = false;
            Boolean confirm = false;

            int index = -1;
            Console.WriteLine("\n--- Delete Book Info---");
            Console.Write("Input book ID: ");
            string ID = Console.ReadLine();

            foreach (var item in ListBooks)
            {
                if (ID.Equals(item.ID))
                {
                    item.ExtractInfo();
                    check = true;
                    confirm = Confirm();
                    if (confirm)
                    {
                        index = ListBooks.IndexOf(item);
                    }
                }
            }
            if (confirm)
            {
                ListBooks.RemoveAt(index);
                Console.WriteLine("Removed successfully!");
            }
            if (!check)
            {
                Console.WriteLine("This book ID isn't existed!");
            }


        }

        public static Boolean Confirm()
        {
            string option;
            Console.WriteLine("Proceed?");
            Console.WriteLine("Enter 'Y' = yes / 'N' = no");
            option = Console.ReadLine();

            if (option == "Y" || option == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
