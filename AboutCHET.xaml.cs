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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CHET_WPF
{
    /// <summary>
    /// Interaction logic for AboutCHET.xaml
    /// </summary>
    public partial class AboutCHET : Window
    {
        public AboutCHET()
        {
            InitializeComponent();
            
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
