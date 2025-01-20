using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal interface IUser
    {
      
        int Id { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Email { get; set; }

       void DisplayAll(List<Book> Book);
        void Search(List<Book> Book,string Who);
    }
}
