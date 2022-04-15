using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using UserLogin;

namespace StudentInfoSystem
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private Student _Stud;
    public event PropertyChangedEventHandler PropertyChanged;
        public UserRoles Role { get; set; }


   public Student Stud
        {
            get
            {
                return _Stud;
            }
            set
            {


                if (value != null)
                {
                    _Stud = value;

/*                    enableControls();
*/                    /* showStudent(_Stud);*/

                }
                else
                {
                  /*  Clear();
                    disableControls();*/

                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Stud"));

            }
        }
        private void OnTargetUpdated(Object sender, DataTransferEventArgs args)
        {
            App.Current.MainWindow.DataContext = this;
        }
        public bool Login(string username, string password)
        {
            LoginValidation lv = new LoginValidation(username, password, errorHandlerGUI);
            StudentValidation sv = new StudentValidation();
            User u = new User();
            if (lv.ValidateUserInput(ref u))
            {
                Role = (UserRoles)u.Role;
                Stud = sv.GetStudentDataByUser(u);
                return true;

            }
            return false;

        }
        public static void errorHandlerGUI(String s)
        {
            MessageBox.Show("!!! " + s + " !!!");

        }
    }
}
