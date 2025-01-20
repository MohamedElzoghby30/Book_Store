using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   public class User : UserAndAdmin
    {

      
        public Book Book { get; set; }

        public User()
        {
            Id = 0;
            UserName = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
           
        }

       public List<Book> BuyBook(List<Book>Book, List<Book> BookBuy)
        {
            DisplayAll(Book);
            Console.WriteLine("Enter the Id to Buy The book");
            int id =int.Parse(Console.ReadLine());
            Details( Book , id);
            Console.WriteLine($"  {Book[id-1].Title} Was Buy And The Price Was {Book[id - 1].Price} ");
            BookBuy.Add(Book[id-1]);
            Console.WriteLine($"  Total Order Is :{BookBuy.Sum(x=>x.Price)} ");
            return BookBuy;
        }
        public User IntryUser(List<User> user,int Count)
        {
            User user1 = new User();
            Console.WriteLine("Enter Your Email : ");
            user1.Email = Console.ReadLine();
            Console.WriteLine("Enter Your Name : ");
            user1.UserName = Console.ReadLine();
            Console.WriteLine("Enter  Passworrd for Your Email : ");
            user1.Password = Console.ReadLine();
            user1.Id = Count++;

            user.Add(user1);
            return user1;
             
        }


    }
}
