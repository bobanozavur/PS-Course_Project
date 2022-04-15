﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfExample
{
    public class InfoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter)
        {
            MessageBox.Show("Hello, world!");
            NamesWindow nw = new NamesWindow();
            nw.Show();

        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
