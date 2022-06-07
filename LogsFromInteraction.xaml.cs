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
using System.IO;

namespace CHET_WPF
{
    /// <summary>
    /// Interaction logic for LogsFromInteraction.xaml
    /// </summary>
    public partial class LogsFromInteraction : Window
    {
        public LogsFromInteraction()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\jenni\OneDrive\CHET_WPF\Tracker.txt";
            var str = File.ReadAllText(path);
            Log.Content = str;
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
