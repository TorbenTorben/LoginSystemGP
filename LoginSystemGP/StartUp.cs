using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystemGP
{
    internal class StartUp
    {
        // Constructor
        public StartUp()
        {
            List<User> addedDataUserList = AddData();
            User indputUser = GetInput();
            CheckIfUserExists(addedDataUserList, indputUser);
        }

        private void CheckIfUserExists(List<User> fullUserList, User checkingUser)
        {
            foreach (User user in fullUserList)
            {
                if (checkingUser.Name == user.Name)
                {
                    Console.WriteLine(user.Name + " Already exists");

                    if (checkingUser.Password == user.Password)
                    {
                        Console.WriteLine("Login Works");
                    }
                    else Console.WriteLine("Password does not work");
                }
            }

        }

        private List<User> AddData()
        {
            
            User user1 = new User() { Name = "Hans", Password = "Pass123" };
            User user2 = new User() { Name = "Per", Password = "Pass123" };
            User user3 = new User() { Name = "Søren", Password = "Pass123" };
            List<User> userList = new List<User>() { user1, user2, user3 };
            return userList;
        }

        private User GetInput() 
        {
            Console.Write("Login\nUsername:");
            string inputUsername = Console.ReadLine();
            Console.Write("Password:");
            string inputPassword = Console.ReadLine();

            User user = new User();
            user.Name = inputUsername;
            user.Password = inputPassword;
            return user;
        }
    }

    internal class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}