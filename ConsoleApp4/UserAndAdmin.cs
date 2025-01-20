using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class UserAndAdmin : IUser
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public void DisplayAll(List<Book> Book1)
        {

            if (Book1 != null)
            {
                var Book = Book1.OrderBy(x => x.Id).ToList();
                for (int i = 0; i < Book.Count; i++)
                {
                    Console.Write($"Name: {Book[i].Title} \t");
                    Console.Write($"Id: {Book[i].Id}\t");
                    Console.Write($"Description: {Book[i].Description} \t");
                    Console.Write($"Price: {Book[i].Price}\n");
                    Console.Write("====================\n");


                }
            }
            else 
                Console.WriteLine("No Books Found"); 
                

        }

        public void Search(List<Book> Book, string Who)
        {
           if(Who=="Id")
            {
                Console.WriteLine($"Enter the {Who} to Search The book");
                int id = int.Parse(Console.ReadLine());
                if (Book.Any(x => x.Id == id))
                {

                    var Searched = Book.Where(x => x.Id == id).ToList();
                    foreach (Book book in Searched)
                    {
                        Console.Write($"Name: {book.Title} \t");
                        Console.Write($"Id: {book.Id}\t");
                        Console.Write($"Description: {book.Description} \t");
                        Console.Write($"Price: {book.Price}\n");
                        Console.Write("====================\n");
                    }
                }
                else
                    Console.WriteLine(" Book Not Found");
            }
           else
            {
                Console.WriteLine($"Enter the {Who} to Search The book");
                String Name = Console.ReadLine();
                if (Book.Any(x => x.Title == Name))
                {

                    var Searched = Book.Where( x => x.Title.Contains(Name)).ToList();
                    foreach (Book book in Searched)
                    {
                        Console.Write($"Name: {book.Title} \t");
                        Console.Write($"Id: {book.Id}\t");
                        Console.Write($"Description: {book.Description} \t");
                        Console.Write($"Price: {book.Price}\n");
                        Console.Write("====================\n");
                    }
                }
                else
                    Console.WriteLine(" Book Not Found");
            }
           
        }
       
        public void Details(List<Book> Book,int id)
        {
           
            if (!Book.Any(x => x.Id == id))
                Console.WriteLine("Error Id :");
            else

            {
                Console.WriteLine($"Name: {Book[id - 1].Title}");
                Console.WriteLine($"Id: {Book[id - 1].Id}");
                Console.WriteLine($"Price: {Book[id - 1].Price}");
            }

        }
    }
}
