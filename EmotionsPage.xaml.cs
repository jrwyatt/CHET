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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;


namespace CHET_WPF
{
    /// <summary>
    /// Interaction logic for EmotionsPage.xaml
    /// </summary>
    public partial class EmotionsPage : Page
    {
        public EmotionsPage()
        {
            InitializeComponent();
            PopulateEmotions();
        }

        private void PopulateEmotions()
        {
            EmotionsList.ItemsSource = new List<string> { "Happy", "Sad", "Hurt", "Mad", "Jealous", "Scared", "Shy", "Loved", "Proud" };
        }

        private void EmotionsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            string SelectedItem = EmotionsList.Text;
            
            File.AppendAllLines(@"C:\Users\jenni\OneDrive\CHET_WPF\Tracker.txt", new [] {SelectedItem + " , " + DateTime.Now});
            
            ChoicesPage choicesPage = new ();
            choicesPage.ShowDialog();
             
        }


    }
}
