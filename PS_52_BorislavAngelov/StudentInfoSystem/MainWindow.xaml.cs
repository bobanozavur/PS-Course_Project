using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserLogin;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ShowCommand ShowInformation { get; set; }
        public List<string> StudStatusChoices { get; set; }
        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new
            SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery =
                @"SELECT StatusDescr FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)

                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    notEndOfResult = reader.Read();
                }
            }
        }
        public bool TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> queryStudents = context.Students;
            int countStudents = queryStudents.Count();
            if(countStudents == 0)
            {
                return true;
            }
            return false;
        }
        public void CopyTestStudents()
        {
            StudentInfoContext context = new StudentInfoContext();
            foreach (Student st in StudentData.TestStudents)
            {
                context.Students.Add(st);

            }
            context.SaveChanges();
        }
        public bool TestUsersIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<User> queryUsers = context.Users;
            int countUsers = queryUsers.Count();
            if (countUsers == 0)
            {
                return true;
            }
            return false;
        }
        public void CopyTestUsers()
        {
            StudentInfoContext context = new StudentInfoContext();
            foreach (User u in UserData.TestUsers)
            {
                context.Users.Add(u);

            }
            context.SaveChanges();
        }


        public static void errorHandlerGUI(String s)
        {
            MessageBox.Show("!!! " + s + " !!!");

        }
   

            public MainWindow()
        {
            InitializeComponent();
            //Test
            /*  StudentsByGroups sg = new StudentsByGroups();

              sg.Show();
              this.Close();*/
            //Login
            Login log = new Login();
            log.Show();
            this.Close();

            //10 upr
            /*       this.DataContext = this;

                   FillStudStatusChoices();
                   if (TestStudentsIfEmpty())
                   {
                       CopyTestStudents();
                   }
                   if (TestUsersIfEmpty())
                   {
                       CopyTestUsers();
                   }*/

        }
        public MainWindow(MainWindowVM mwvm)
        {
            InitializeComponent();
            this.DataContext = mwvm;
            ShowInformation = new ShowCommand();



        }
      
    

        public void sixthExercise()
        {
            LoginValidation lv = new LoginValidation("Jerry", "easyPass", errorHandlerGUI);

            if (LoginValidation.CurrentUserRole.Equals(UserRoles.ADMIN))
            {
                administratorOptions();
            }
            administratorOptions();
        }
        public void administratorOptions()
        {
            ChooseList choose = new ChooseList();
            choose.Show();
        }
        public void Clear()
        {

            foreach (var item in MainGrid2.Children)
            {

                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";

                }

            }
            foreach (var item in MainGrid3.Children)
            {

                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";

                }

            }

        }
        private void checkLastLogin(Student s)
        {
            User user = null;
            foreach(User u in UserData.TestUsers)
            {
                if (u.FakNum.Equals(s.FacultyNumber))
                {
                    user = u;
                    break;
                }
            }
            IEnumerable<String> enumer = Logger.getFullLog();
            String lastLogin = "empty";
            /*   foreach (String str in enumer)
               {
                   MessageBox.Show(str);
                   if (str.Contains(user.Username + ";" + (UserRoles)user.Role + ";Успешен Login"))
                   {
                       lastLogin = str;
                   }
               }*/
            lastLogin = (from date in enumer
                                where date.Contains(user.Username + ";" + (UserRoles)user.Role + ";Успешен Login")
                                select date).Last();
            MessageBox.Show(lastLogin);
        }

        private void OnTargetUpdated(Object sender, DataTransferEventArgs args)
        {

        }
        private void showStudent(Student s)
        {
            txtCourse.Text = s.Course.ToString();
            txtFaculty.Text = s.Faculty;
            txtFakNum.Text = s.FacultyNumber;
            txtFamilyName.Text = s.LastName;
            txtGroup.Text = s.Group.ToString();
            txtName.Text = s.Name;
            txtOKS.Text = s.Degree;
            txtPotok.Text = s.Potok.ToString();
            txtSecondName.Text = s.Surname;
            txtSpec.Text = s.Major;
            /*txtStatus.Text = ((Statuses)s.Status).ToString();*/
            if (MessageBox.Show("Show Last Login?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {

            }
            else
            {
                checkLastLogin(s);
            }

        }
        private void disableControls()
        {
            foreach (var item in MainGrid2.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;

                }
            
            }
            foreach (var item in MainGrid3.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;

                }

            }
        }
        private void enableControls()
        {
            foreach (var item in MainGrid2.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;

                }

            }
            foreach (var item in MainGrid3.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;

                }

            }
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;

                }
            
            }
        }

      
    }
 
}
