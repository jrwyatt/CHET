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

namespace CHET_WPF
{
    /// <summary>
    /// Interaction logic for ParentLogin.xaml
    /// </summary>
    public partial class ParentLogin : Window
    {
        public ParentLogin()
        {
            InitializeComponent();
            MainWindow mainWindow = new MainWindow();
        }

        private void PasswordLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            LogsFromInteraction logsFromInteraction = new();
            logsFromInteraction.ShowDialog();
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
