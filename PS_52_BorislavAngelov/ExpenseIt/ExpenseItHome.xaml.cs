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
using System.Collections.ObjectModel;

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    
    public partial class ExpenseItHome : Window, INotifyPropertyChanged
    {
        public string MainCaptionText { get; set; }
        public List<Person> ExpenseDataSource { get; set; }
        public ObservableCollection<string> PersonsChecked
        { get; set; }
        
        private DateTime lastChecked;
        public DateTime LastChecked { get { return lastChecked; } 
            set{
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("LastChecked"));
                }
                lastChecked = value; 
            } }
        public event PropertyChangedEventHandler PropertyChanged;
        public ExpenseItHome()
        {
            InitializeComponent();
            MainCaptionText = "View Expense Report :";
            LastChecked = DateTime.Now;
            this.DataContext = this;
            PersonsChecked = new ObservableCollection<string>();
            ExpenseDataSource = new List<Person>(){
new Person()
{

Name="Mike",
Department ="Legal",
Expenses = new List<Expense>()
{
new Expense() { ExpenseType="Lunch", ExpenseAmount =50 },
new Expense() { ExpenseType="Transportation", ExpenseAmount=50 }
}
},
new Person()
{
Name ="Lisa",
Department ="Marketing",
Expenses = new List<Expense>()
{
new Expense() { ExpenseType="Document printing", ExpenseAmount=50 },
new Expense() { ExpenseType="Gift", ExpenseAmount=125 }
}
},
new Person()
{
Name="John",
Department ="Engineering",
Expenses = new List<Expense>()
{
new Expense() { ExpenseType="Magazine subscription", ExpenseAmount=50 },
new Expense() { ExpenseType="New machine", ExpenseAmount=600 },
new Expense() { ExpenseType="Software", ExpenseAmount=500 }
}
},
new Person()
{
Name="Mary",
Department ="Finance",
Expenses = new List<Expense>()
{
new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
}
},
new Person()
{
Name="Theo",
Department ="Marketing",
Expenses = new List<Expense>()
{
new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
}
},
new Person()
{
Name="James",
Department ="Legal",
Expenses = new List<Expense>()
{
new Expense() { ExpenseType="Suit", ExpenseAmount=3000 },
new Expense() { ExpenseType="Hair", ExpenseAmount=300 }

}
},
new Person()
{
Name="David",
Department ="Finance",
Expenses = new List<Expense>()
{
new Expense() { ExpenseType="Gift", ExpenseAmount=126 },
new Expense() { ExpenseType="Dinner", ExpenseAmount=200 },
}
}
};
            
    
    }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExpenseReport expRep = new ExpenseReport(peopleListBox.SelectedItem);
            expRep.Height = this.Height;
            expRep.Width = this.Width;
            expRep.ShowDialog();
           
        }
        private void peopleListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)

        {

            LastChecked = DateTime.Now;
            PersonsChecked.Add((peopleListBox.SelectedItem as Person).Name);
        }

    }
    public class Expense
    {
        public string ExpenseType { get; set; }
        public double ExpenseAmount { get; set; }
    }
    public class Person
    {
        public string Name { get; set; }
        
        public string Department { get; set; }
        public List<Expense> Expenses { get; set; }
    }
}
