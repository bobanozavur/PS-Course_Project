using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace StudentInfoSystem
{
    public class ShowCommand : ICommand
    {
        public void Execute(object parameter)
        {
            MessageBox.Show(App.Current.StartupUri.ToString(), "About", MessageBoxButton.OK, MessageBoxImage.Warning);


        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
