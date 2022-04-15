using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;


namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window, INotifyPropertyChanged
    {
        public Login()
        {
            InitializeComponent();
            this.DataContext = this;
            RegisterButtonClicked = new RelayCommand(RegisterUser, CanUserRegister);
            ResetButtonClicked = new RelayCommand(ResetPage, CanResetPage);
            ShowInformation = new ShowCommand();
            
        }
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set {
                if (_userName != value)
                {
                    _userName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged("Password");
                }
            }
        }
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


        private bool _isButtonClicked;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsButtonClicked
        {
            get { return _isButtonClicked; }
            set { _isButtonClicked = value; }
        }


        #region ICommands  
        public ICommand RegisterButtonClicked { get; set; }
        public ICommand ResetButtonClicked { get; set; }
        public ShowCommand ShowInformation { get; set; }
        #endregion



        private void RegisterUser(object value)
        {
            IsButtonClicked = true;

            MainWindowVM vm = new MainWindowVM();

            if (vm.Login(UserName, Password))
            {
                if (vm.Role.Equals(UserLogin.UserRoles.ADMIN))
                {
                    SubjectAdder sa = new SubjectAdder();
                    sa.Show();
                }
                else if (vm.Role.Equals(UserLogin.UserRoles.PROFESSOR))
                {
                    StudentsByGroups sb = new StudentsByGroups();
                    sb.Show();
                }
                else 
                {
                    MainWindow mw = new MainWindow(vm);


                    mw.Show();
                }                
            }
            else
            {
            }

        }

        private bool CanUserRegister(object value)
        {

            if (string.IsNullOrEmpty(UserName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ResetPage(object value)
        {
            IsButtonClicked = false;
            UserName = Password = "";
        }

        private bool CanResetPage(object value)
        {
            if (string.IsNullOrEmpty(UserName)
                || string.IsNullOrEmpty(Password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
