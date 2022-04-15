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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);
            ListBoxItem david = new ListBoxItem();
            david.Content = "David";
            peopleListBox.Items.Add(david);
            peopleListBox.SelectedItem = james;
        }

  


        private void btnFact_Click(object sender, RoutedEventArgs e)
        {
            int num = Int32.Parse(txtFact.Text);
            if (num > 1)
            {
                int fact = 1;
                num += 1;
                for (int i = 1; i < num; i++)
                {
                    fact *= i;
                }
                txtFact.Text = fact.ToString();
            }
          
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder s = new StringBuilder();
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    s.Append(((TextBox)item).Text+"\n");
                }
            }
            MessageBox.Show(s.ToString());

        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you really want to do that?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();
        }

        private void btnGreeting_Click(object sender, RoutedEventArgs e)
        {
            string greetingMsg;

            greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            MessageBox.Show("Hi " + greetingMsg);
        }
    }
}
