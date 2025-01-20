using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Admin : UserAndAdmin
    {
       

        public Admin()
        {
        
             Id = 0;
             UserName = string.Empty;
             Password = string.Empty;
             Email = string.Empty;
        
        }

        public void Add(List<Book> Book, ref int Counter)
        {
            Console.Clear();
            Book books = new Book();           
            books= Intry(Book, "Book");
            books.Id = Counter + 1;
            Counter++;
            Book.Add(books);
            Console.WriteLine($"  {Book[Counter-1].Title} Was  Add === ");
            Console.WriteLine("==========================================");


        }
        public void Remove(List<Book> Book)
        { 
            Console.Clear();
            DisplayAll(Book);
            Console.WriteLine("Enter the Id to Remove The book");
            int id = int.Parse(Console.ReadLine());
            if (!Book.Any(z=>z.Id==id))
                Console.WriteLine("Error Id :");
            else
                Book.Remove(Book[id - 1]);

        }
        public void Update(List<Book> Book)
        {
            Console.Clear();
            DisplayAll(Book);
            Console.Write("Enter The Id of the Book :");
            int id = int.Parse(Console.ReadLine());
            if (!Book.Any(z => z.Id == id))
                Console.WriteLine("  Error Id  ");
            else
            {
                Console.WriteLine("The Details of book");
                Console.WriteLine($"Name: {Book[id - 1].Title}");
                Console.WriteLine($"Description: {Book[id - 1].Description}");
                Console.WriteLine($"Id: {Book[id - 1].Id}");
                Console.WriteLine($"Price: {Book[id - 1].Price}");
                Book book = new Book();
                book= Intry(Book,"New");
                book.Id = id;
                Book[id - 1] = book;

            }
        }
        static Book Intry(List<Book> book,string Who)
        {
            Book book1 = new Book();
            Console.WriteLine($"Enter The {Who} Name : ");
            book1.Title = Console.ReadLine();
            Console.WriteLine($"Enter The {Who} Description : ");
            book1.Description = Console.ReadLine();
            Console.WriteLine($"Enter The {Who} price : ");
            book1.Price = decimal.Parse(Console.ReadLine());
            return book1;
        }
    }
}
