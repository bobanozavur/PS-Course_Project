using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        public static void errorHandler(String s)
        {
            Console.WriteLine("!!! " + s + " !!!");

        }
        public static void adminMenu()
        {
            string username;
            int id;
            int role;
            DateTime date;
            while (true)
            {
                Console.WriteLine("Choose an opition: \n0: Exit\n1: Change role of specified user" +
                    "\n2: Change user activity of specified user\n3: Show list of users\n4: Look at " +
                    "the activity log\n5: Show current activity log");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 0)
                {
                    break;
                }
                else if(choice == 1)
                {
                    Console.Write("Type in id: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Type in role number: ");
                    role = Convert.ToInt32(Console.ReadLine());
                    UserData.AssignUserRole(id, (UserRoles)role);

                }
                else if(choice == 2)
                {
                    Console.Write("Type in id: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Type in date: ");
                    date = Convert.ToDateTime(Console.ReadLine());
                    UserData.SetUserActiveTo(id, date);

                }
                else if(choice == 3)
                {

                }
                else if (choice == 4)
                {
                    StringBuilder sb = new StringBuilder();
                    IEnumerable<string> currentActs =
                    Logger.getFullLog();
                    foreach (string line in currentActs)
                    {

                        sb.Append(line + "\n");
                    }
                    Console.WriteLine(sb);
                }
                else if (choice == 5)
                {
                    Console.Write("Enter filter: ");
                    String filter = Console.ReadLine();
                    StringBuilder sb = new StringBuilder();
                    IEnumerable<string> currentActs =
                    Logger.GetCurrentSessionActivities(filter);
                    foreach (string line in currentActs)
                    {
                        sb.Append(line+"\n");
                    }
                    Console.WriteLine(sb);
                }

            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter username: ");
            String username = Console.ReadLine();
            Console.Write("Enter password: ");
            String password = Console.ReadLine();
            DateTime dt = new DateTime(2017, 9, 15, 10, 30, 0);
            Console.WriteLine(dt.Hour);
            dt = DateTime.Now;
            Console.WriteLine(dt.Hour);
            Console.WriteLine(dt.AddHours(12).Day);
            Console.Write("Enter date: ");
            String consoleDate = Console.ReadLine();
            dt = Convert.ToDateTime(consoleDate);
          

            LoginValidation lv = new LoginValidation(username, password, errorHandler);
              User u = new User("Jerry", "easyPass", "121218680", 1);
            User nullUser = null;
              if (lv.ValidateUserInput(ref nullUser))
              {
                Console.WriteLine(u.FakNum);
                Console.WriteLine(u.Password);
                Console.WriteLine((UserRoles)u.Role);
                Console.WriteLine(u.Username);
                Console.WriteLine();
                Console.WriteLine(nullUser.FakNum);
                Console.WriteLine(nullUser.Password);
                Console.WriteLine((UserRoles)nullUser.Role);
                Console.WriteLine(nullUser.Username);
                Console.WriteLine();
                switch (LoginValidation.CurrentUserRole)
                {
                    case UserRoles.ANONYMOUS:
                        Console.WriteLine("Anonymous");
                        break;
                    case UserRoles.ADMIN:
                        Console.WriteLine("Admin");
                        adminMenu();
                        break;
                    case UserRoles.INSPECTOR:
                        Console.WriteLine("Inspector");
                        break;
                    case UserRoles.PROFESSOR:
                        Console.WriteLine("Professor");
                        break;
                    case UserRoles.STUDENT:
                        Console.WriteLine("Student");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;

                }


            }
        }
      
    }
}

