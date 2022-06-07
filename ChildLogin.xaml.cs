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
    /// Interaction logic for ChildLogin.xaml
    /// </summary>
    public partial class ChildLogin : Window
    {
        public ChildLogin()
        {
            InitializeComponent();
        }


        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Lillian_Click(object sender, RoutedEventArgs e)
        {
            File.AppendAllLines(@"C:\Users\jenni\OneDrive\CHET_WPF\Tracker.txt", new[] { "Lillian logged in: " });
            MessageBox.Show("HI LILLY BEAN!");
            this.Close();
            ChildWelcomeScreen childWelcomeScreen = new();
            childWelcomeScreen.ShowDialog();
        }

        private void Button_Jeffery_Click(object sender, RoutedEventArgs e)
        {
            File.AppendAllLines(@"C:\Users\jenni\OneDrive\CHET_WPF\Tracker.txt", new[] { "Jeffery logged in: " });
            MessageBox.Show("HI BUBBA J!");
            this.Close();
            ChildWelcomeScreen childWelcomeScreen = new ();
            childWelcomeScreen.ShowDialog();
        }

        //need to write code, that if a child's name is selected, it is set to ChildName in "ChildWelcomeScreen"
    }
}
