using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   
    internal class Program
    {
        static void Main(string[] args)
        {



            int Counter = 0;
            List<Book> book = new List<Book>()
            {
               


            };
            List<Book> bookBuy = new List<Book>();
            List<Admin> admins = new List<Admin>() 
            { 
            new Admin()
            {
                Id= 20006,
                UserName="Ali Mohamed",
                Email ="cf500bbac4@emailfoxi.pro",
                Password ="jkasj3333955"
            },
             new Admin()
            {
                Id= 28006,
                UserName="Osama Khaled",
                Email ="cf500bbac4@emailfoxi.pro",
                Password ="cf500789bbac4"
            }

            };
            List<User> users = new List<User>()
            {
            new User()
            {
                Id= 96006,
                UserName="Karem Mohamed",
                Email ="cf500bbac4@emailfoxi.pro",
                Password ="jk00asj955"
            },
             new User()
            {
                Id= 72006,
                UserName="Nada Ibrahim",
                Email ="cf500bbac4@emailfoxi.pro",
                Password ="cf58500bbac4"
            }, new User()
            {
                Id= 785206,
                UserName="Eman Abdellatif",
                Email ="cf500bbac4@emailfoxi.pro",
                Password ="8as0bbac454"
            }
            , new User()
            {
                Id= 20206,
                UserName="Mohamed El-zoghby",
                Email ="cf500bbac4@emailfoxi1.pro",
                Password ="8as9630bbac45"
            }

            };
            Admin admin = new Admin();
            User user = new User();
            Console.WriteLine("Hello in The book Store ");
            Console.WriteLine("==== Login Or Regester ====");
            string LoginOrRegester = Console.ReadLine().ToLower();
            if (LoginOrRegester == "regester")
            {
                user.IntryUser(users, users.Max(x => x.Id));

            }
            while (true)
            {      
                        Console.Clear();
                        Console.WriteLine("Hello in The book Store ");
                        Console.Write("Please Enter The Email :");
                        string InputName = Console.ReadLine();
                        Console.Write("Please Enter The Passworrd :");
                        String pass = Console.ReadLine();
                        var EnterUser = users.Any(x => x.Password == pass && x.Email == InputName);
                        var EnterAdmin = admins.Any(x => x.Password == pass && x.Email == InputName);

                        if (EnterAdmin == true)
                            while (true)
                            {
                                var NameAdmin = admins.First(x => x.Password == pass && x.Email == InputName);
                                Console.WriteLine("===== Admin Page =====");
                                Console.WriteLine($" ===== Hello Mr {NameAdmin.UserName}  =====");
                                Console.Write("0 to LogOut\n1 to add\n2 to remove\n3 to update\n4 to Search\n5 to display all\n");
                                int choice = int.Parse(Console.ReadLine());
                                if (choice == 0)
                                    break;
                                switch (choice)
                                {
                                    case 1:
                                        admin.Add(book, ref Counter);
                                        break;
                                    case 2:
                                        admin.Remove(book);
                                        break;
                                    case 3:
                                        admin.Update(book);
                                        break;
                                    case 4:
                                        admin.Search(book, "Id");
                                        break;
                                    case 5:
                                        admin.DisplayAll(book);
                                        break;

                                    default:
                                        Console.WriteLine("========  Error   Input  ==========  ");
                                        break;
                                }
                            }
                        else if (EnterUser == true)
                            while (true)
                            {
                                var NameUser = users.First(x => x.Password == pass && x.Email == InputName);
                                Console.WriteLine("===== User Page =====");
                                Console.WriteLine($" ===== Hello Mr {NameUser.UserName}  =====");
                                Console.Write("0 to LogOut\n 1 to display all\n  2 to Search\n 3 to Buy\n");
                                int choice = int.Parse(Console.ReadLine());
                                if (choice == 0)
                                    break;
                                switch (choice)
                                {
                                    case 1:
                                        user.DisplayAll(book);
                                        break;
                                    case 2:
                                        user.Search(book, "Name");
                                        break;
                                    case 3:
                                        var BooksBuy = user.BuyBook(book, bookBuy);
                                        break;


                                    default:
                                        Console.WriteLine("Error");
                                        break;


                                }
                            }

                        else
                        {

                            Console.WriteLine("====== Error in Pass or Email ========");
                        }

                    }
            }
        }
    }