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

        private void CheckMakeUser(List<User> fullUserList, User checkingUser)
        {
            foreach (User user in fullUserList)
            {
                if (checkingUser.Name == user.Name)
                {
                    Console.WriteLine(user.Name + " Already exists");

                    Console.ReadKey();

                    Environment.Exit(0);

                }
                if (checkingUser.Password.Length >= 12 && checkingUser.Password.Any(char.IsDigit) && checkingUser.Password.Any(char.IsLetter) &&
                         checkingUser.Password.Any(char.IsLower) && checkingUser.Password.Any(char.IsUpper) && !checkingUser.Password.Any(char.IsWhiteSpace) &&
                         !char.IsDigit(checkingUser.Password[0]) && !checkingUser.Password.All(char.IsLetterOrDigit))
                {
                    Console.WriteLine("Login Works");
                }
                else Console.WriteLine("Password does not work");

                Console.ReadKey();

                Environment.Exit(0);
            }

        }

        public void CheckIfUserExists(List<User> fullUserList, User checkingUser)
        {
            foreach (User user in fullUserList)
            {
                if (checkingUser.Name == user.Name)
                {
                    Console.WriteLine("Wellcome " + user.Name);

                    if (checkingUser.Password == user.Password)
                    {
                        Console.WriteLine("Login Works");
                    }
                    else Console.WriteLine("Password does not work");
                }
            }

        }

        public List<User> AddData()
        {

            User user1 = new User() { Name = "Hans", Password = "Pass123" };
            User user2 = new User() { Name = "Per", Password = "Pass123" };
            User user3 = new User() { Name = "Søren", Password = "Pass123" };
            List<User> userList = new List<User>() { user1, user2, user3 };
            return userList;
        }

        public User GetInput()
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

        internal class MakeUser
        {
            public MakeUser()
            {
                List<User> addedDataUserList = AddData();
                User newUserIndput = GetInput();
                CheckMakeUser(addedDataUserList, newUserIndput);
            }
        }
       

    }


    //internal class MakeUser
    //{
    //    public MakeUser()
    //    {
    //         List<User> addedDataUserList = AddData();
    //         User newUserIndput = GetInput();
    //         CheckMakeUser(addedDataUserList, newUserIndput);
    //    }
    //}
    



    internal class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}