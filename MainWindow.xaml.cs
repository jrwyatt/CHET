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

namespace CHET_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Buttonchild_Click(object sender, RoutedEventArgs e)
        {
            ChildLogin childLogin = new();
            childLogin.ShowDialog();
        }

        private void Buttonparent_Click(object sender, RoutedEventArgs e)
        {
            ParentLogin parentLogin = new();
            parentLogin.ShowDialog();
        }

        private void Buttonabout_Click(object sender, RoutedEventArgs e)
        {
            AboutCHET aboutCHET = new();
            aboutCHET.ShowDialog();
        }

    }
}
