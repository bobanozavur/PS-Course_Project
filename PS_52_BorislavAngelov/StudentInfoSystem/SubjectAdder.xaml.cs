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
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for SubjectAdder.xaml
    /// </summary>
    public partial class SubjectAdder : Window
    {
        SubjectAdderVM vm = new SubjectAdderVM();
        public SubjectAdder()
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}
