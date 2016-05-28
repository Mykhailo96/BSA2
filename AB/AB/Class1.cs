using System;
using System.Collections.Generic;

namespace AB
{
    public class AddressBook
    {
        private List<User> users = new List<User>();

        public bool AddUser()
        {
            try
            {
                User user = new User();

                Console.WriteLine("Last name");
                user.LastName = Console.ReadLine();

                Console.WriteLine("First name");
                user.FirstName = Console.ReadLine();

                Console.WriteLine("Birthdate");
                user.Birthdate = DateTime.Parse(Console.ReadLine());

                user.TimeAdded = DateTime.Now;

                Console.WriteLine("City");
                user.City = Console.ReadLine();

                Console.WriteLine("Address");
                user.Address = Console.ReadLine();

                Console.WriteLine("Phone number");
                user.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Gender");
                user.Gender = Console.ReadLine();

                Console.WriteLine("Email");
                user.Email = Console.ReadLine();

                users.Add(user);

                if(UserAdded != null)
                {
                    UserAdded("adding new user");
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool RemoveUser()
        {

            try
            {
                Console.WriteLine("Write last name");

                users.Remove(users.Find(x => x.LastName == Console.ReadLine()));

                if(UserRemoved != null)
                {
                    UserRemoved("removing user");
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public delegate void ABDelegate(string str);

        public event ABDelegate UserAdded;
        public event ABDelegate UserRemoved;

        public void AllUsers()
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine(users[i].LastName + " " + users[i].FirstName + "\n");
            }
        }
    }
}
