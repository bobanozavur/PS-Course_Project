using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static public class UserData
    {
        static private List<User> _testUsers;
        static public List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }

        static private void ResetTestUserData()
        {


            if (_testUsers == null)
            {
                _testUsers = new List<User>();
                _testUsers.Add(new User("Jerry", "easyPass", "121218680", 1, DateTime.Now));
                _testUsers[0].ActiveUntil = DateTime.MaxValue;
                 _testUsers.Add(new User("Garry", "easyPass1", "121218681", 4,DateTime.Now));
                _testUsers[1].ActiveUntil = DateTime.MaxValue;
                 _testUsers.Add(new User("Berry", "easyPass2", "121218682", 4, DateTime.Now));
                _testUsers[2].ActiveUntil = DateTime.MaxValue;


            }
        }
        static public User IsUserPassCorrect(String username, String password)
        {
            UserContext context =new UserContext();
            try
            {
                User u = (from user in context.Users
                          where user.Username.Equals(username) && user.Password.Equals(password)
                          select user).First();
                return u;
        }
            catch(System.InvalidOperationException e)
            {
                return null;
            }
}
        static public void SetUserActiveTo(string username, DateTime date)
        {
            foreach(User u in TestUsers)
            {
                if (u.Username.Equals(username))
                {
                    u.ActiveUntil = date;
                    Logger.LogActivity("Промяна на активност на " + username);
                }
            }
        }
        static public void SetUserActiveTo(int userid, DateTime date)
        {
            UserContext context = new UserContext();

            try
            {
                User usr =
                       (from u in context.Users
                        where u.UserId == userid
                        select u).First();
                usr.ActiveUntil = date;
                Logger.LogActivity("Промяна на активност на " + usr.Username); //в AssignUserRole

                context.SaveChanges();
            }
            catch (System.InvalidOperationException)
            {

            }
        }
        public static void AssignUserRole(string username, UserRoles role)
        {
            foreach (User u in TestUsers)
            {
                if (u.Username.Equals(username))
                {
                    u.Role = (int)role;
                    Logger.LogActivity("Промяна на роля на " + username); //в AssignUserRole
                }
            }
        }
        public static void AssignUserRole(int userid, UserRoles role)
        {
            UserContext context =new UserContext();

            try
            {
                User usr =
                       (from u in context.Users
                        where u.UserId == userid
                        select u).First();
                usr.Role = (int)role;
                Logger.LogActivity("Промяна на роля на " + usr.Username); //в AssignUserRole

                context.SaveChanges();
            }
            catch (System.InvalidOperationException)
            {

            }
       
        }

    }
}