using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CHET_WPF
{
    public partial class FeelingsCheckPoint : Form
    {
        public FeelingsCheckPoint()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            File.AppendAllLines(@"C:\Users\jenni\OneDrive\CHET_WPF\Tracker.txt", new[] { "FEELS BETTER" });
            MessageBox.Show("So proud of you for handling emotions in a healthy way!!");
            this.Close();
        }
    
        private void No_Click(object sender, EventArgs e)
        {
            File.AppendAllLines(@"C:\Users\jenni\OneDrive\CHET_WPF\Tracker.txt", new[] { "Needed another attempt. " });
            this.Close();
        }

        private void Yes_Click_1(object sender, EventArgs e)
        {
            File.AppendAllLines(@"C:\Users\jenni\OneDrive\CHET_WPF\Tracker.txt", new[] { "Felt better" });
            this.Close();
        }
    }
}
