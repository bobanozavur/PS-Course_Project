using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{

    public class LoginValidation
    {
        private static String username;
        private String password;
        private String errorMessage;
        private static UserRoles userRole;
        public static String currentUsername
        {
            get
            {
                return username;
            }
            set { }
        }
        public delegate void ActionOnError(string errorMsg);
        private ActionOnError errorfunc { get; set; }

        public LoginValidation (String _username, String _password, ActionOnError _errorfunc)
        {
            username = _username;
            password = _password;
            errorfunc = _errorfunc;
        }
        public static UserRoles CurrentUserRole
        {
            get
            {
                return userRole;
            }
            set
            {
            }
        }
        public bool ValidateUserInput(ref User u)
        {

            userRole = (UserRoles)0;

            Boolean emptyUserName = username.Equals(String.Empty);

            if (emptyUserName == true)
            {
                errorMessage = "Не е посочено потребителско име.";
                errorfunc(errorMessage);
                return false;
            }
            Boolean emptyPassword = password.Equals(String.Empty);
            if (emptyPassword == true)
            {
                errorMessage = "Не е посочена парола.";
                errorfunc(errorMessage);

                return false;
            }
            Boolean tooShort=false;
            if (password.Length < 5 || username.Length < 5)
            {
                tooShort = true;
            }
            if(tooShort == true)
            {
                errorMessage = "Паролата и потребителското име трябва да са минимум 5 символа";
                errorfunc(errorMessage);

                return false;
            }
            if (UserData.IsUserPassCorrect(username, password) == null)
            {
                errorMessage = "Не съществува потребител с въведените данни";
                errorfunc(errorMessage);

                return false;
            }
            u = UserData.IsUserPassCorrect(username, password);

            userRole = (UserRoles)u.Role;

            Logger.LogActivity("Успешен Login"); //във ValidateUserInput
            return true;
           
        }
    }
}
