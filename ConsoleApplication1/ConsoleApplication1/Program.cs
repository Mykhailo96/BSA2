using System;
using AB;
using Log;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook book = new AddressBook();

            book.UserRemoved += Logger.Instance.Info;
            book.UserAdded += Logger.Instance.Info;

            string answer;

            do
            {
                Console.WriteLine("Add user - A, delete user - D, show all users - L, quit - Q");
                answer = Console.ReadLine();
                                
                switch (answer.ToUpper())
                {
                    case "A":
                        {
                            book.AddUser();
                            break;
                        }
                    case "D":
                        {
                            book.RemoveUser();
                            break;
                        }
                    case "Q":
                        Console.WriteLine("Exiting..");
                        break;
                    case "L":
                        {
                            book.AllUsers();
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong input. Try again");
                        break;
                }
            }
            while (answer.ToLower() != "q");
        }
    }
}
