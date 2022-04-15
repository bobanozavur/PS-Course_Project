﻿using System;
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
using UserLogin;


namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for userList.xaml
    /// </summary>
    public partial class userList : Window
    {
        public userList()
        {
            InitializeComponent();
            foreach(User u in UserData.TestUsers)
            {
                userListBox.Items.Add(u.Username);
            }
        }
    }
}
