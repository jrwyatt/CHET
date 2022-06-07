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
    /// Interaction logic for ChoicesPage.xaml
    /// </summary>
    public partial class ChoicesPage : Window
    {
        public ChoicesPage()
        {
            InitializeComponent();
            var last = File.ReadLines(@"C:\Users\jenni\OneDrive\CHET_WPF\Tracker.txt").Last();
            string[] word = last.Split(' ');
            string word2 = word[0];

            switch (word2) {
                case "Happy":
                    {
                        Button button1 = new();
                        button1.Content = "Let mommy and/or daddy know why you are happy!";
                        stackpanel1.Children.Add(button1);
                        Button button2 = new();
                        button2.Content = "Enjoy the moment, go continue being happy!";
                        stackpanel1.Children.Add(button2);
                        Button button3 = new();
                        button3.Content = "Talk to God about what made you happy and you're grateful for it";
                        stackpanel1.Children.Add(button3);
                        Button button4 = new();
                        button4.Content = "Do something kind for someone else";
                        stackpanel1.Children.Add(button4);
                        button1.Click += Button_Click;
                        button2.Click += Button_Click;
                        button3.Click += Button_Click;
                        button4.Click += Button_Click;
                        break;
                    }
                case "Sad":
                    {
                        Button button5 = new();
                        button5.Content = "Do you miss someone or something? Talk about them to a friend.";
                        stackpanel1.Children.Add(button5);
                        Button button6 = new();
                        button6.Content = "Did something not go your way? Ask to talk to person involved";
                        stackpanel1.Children.Add(button6);
                        Button button7 = new();
                        button7.Content = "It's ok to cry if you need to.";
                        stackpanel1.Children.Add(button7);
                        Button button8 = new();
                        button8.Content = "Share your feelings with mommy or daddy";
                        stackpanel1.Children.Add(button8);
                        Button button9 = new();
                        button9.Content = "Take a nap!";
                        stackpanel1.Children.Add(button9);
                        Button button10 = new();
                        button10.Content = "Pray about why you are sad and for help in healing.";
                        stackpanel1.Children.Add(button10);
                        button5.Click += Button_Click;
                        button6.Click += Button_Click;
                        button7.Click += Button_Click;
                        button8.Click += Button_Click;
                        button9.Click += Button_Click;
                        button10.Click += Button_Click;
                        break;
                    }
                case "Hurt":
                    {
                        Button button11 = new();
                        button11.Content = "Is it physical pain? Take a few deep breaths to calm and see how bad it is.";
                        stackpanel1.Children.Add(button11);
                        Button button12 = new();
                        button12.Content = "Do you need to clean up the injury? Ask mommy or daddy for help if it's bleeding a lot or broken.";
                        stackpanel1.Children.Add(button12);
                        Button button13 = new();
                        button13.Content = "Are your feelings hurt? After you are calm, tell the person who hurt your feelings specifically what they did.";
                        stackpanel1.Children.Add(button13);
                        Button button14 = new();
                        button14.Content = "If you don't feel comfortable talking to the person yourself, you can always talk to mommy or daddy.";
                        stackpanel1.Children.Add(button14);
                        Button button15 = new();
                        button15.Content = "Pray about what hurt you, pray the person learns to stop being mean, pray for the strength to forgive so you can be happy.";
                        stackpanel1.Children.Add(button15);
                        button11.Click += Button_Click;
                        button12.Click += Button_Click;
                        button13.Click += Button_Click;
                        button14.Click += Button_Click;
                        button15.Click += Button_Click;
                        break;
                    }  
                case "Mad": 
                    {
                        Button button16 = new();
                        button16.Content = "Count to 15 and take 3 deep breaths after.";
                        stackpanel1.Children.Add(button16);
                        Button button17 = new();
                        button17.Content = "Change activities or people you're with.";
                        stackpanel1.Children.Add(button17);
                        Button button18 = new();
                        button18.Content = "Alone time activity: medidate, read a book, draw a picture, color a picture until you are calm.";
                        stackpanel1.Children.Add(button18);
                        Button button19 = new();
                        button19.Content = "Take a nap.";
                        stackpanel1.Children.Add(button19);
                        Button button20 = new();
                        button20.Content = "Once calm, tell person who made you mad specifically what they did.";
                        stackpanel1.Children.Add(button20);
                        Button button21 = new();
                        button21.Content = "Tell mommy or daddy about it.  Ask for help finding a solution if you need one.";
                        stackpanel1.Children.Add(button21);
                        Button button22 = new();
                        button22.Content = "Pray for patience to not get so mad";
                        stackpanel1.Children.Add(button22);
                        button16.Click += Button_Click;
                        button17.Click += Button_Click;
                        button18.Click += Button_Click;
                        button19.Click += Button_Click;
                        button20.Click += Button_Click;
                        button21.Click += Button_Click;
                        button22.Click += Button_Click;
                        break;
                    }
                case "Jealous":
                    {
                        Button button23 = new();
                        button23.Content = "Instead of feeling bad, feel happy for whoever did something great or has something super cool.";
                        stackpanel1.Children.Add(button23);
                        Button button24 = new();
                        button24.Content = "If someone has something you want, ask mommmy and daddy how it's possible for you to earn it.";
                        stackpanel1.Children.Add(button24);
                        Button button25 = new();
                        button25.Content = "If it's something someone has good skills at, work hard on developing your skills! Ask them how they got so good. Celebrate their success and yours will come";
                        stackpanel1.Children.Add(button25);
                        Button button26 = new();
                        button26.Content = "Sometimes, other people get and have things we wont, make a list of all the amazing things you can do and what you have!";
                        stackpanel1.Children.Add(button26);
                        Button button27 = new();
                        button27.Content = "Take time to thank God for everything you are thankful you have! Being positive will help change your mindset";
                        stackpanel1.Children.Add(button27);
                        button23.Click += Button_Click;
                        button24.Click += Button_Click;
                        button25.Click += Button_Click;
                        button26.Click += Button_Click;
                        button27.Click += Button_Click;
                        break;
                    }  
                case "Scared": 
                    {
                        Button button28 = new();
                        button28.Content = "Talk to Mommy or Daddy so you can find a solution.";
                        stackpanel1.Children.Add(button28);
                        Button button29 = new();
                        button29.Content = "Remember it's ok if it doesn't work, but you try again and try better until you get it!";
                        stackpanel1.Children.Add(button29);
                        Button button30 = new();
                        button30.Content = "Ask a friend to stay with you and help";
                        stackpanel1.Children.Add(button30);
                        Button button31 = new();
                        button31.Content = "Say to yourself: 'I got this! I can do this!' and GO!! YOU GOT THIS, KIDDO!";
                        stackpanel1.Children.Add(button31);
                        Button button32 = new();
                        button32.Content = "Remember God is always with you to give you strength and courage!";
                        stackpanel1.Children.Add(button32);
                        button28.Click += Button_Click;
                        button29.Click += Button_Click;
                        button30.Click += Button_Click;
                        button31.Click += Button_Click;
                        button32.Click += Button_Click;
                        break;
                    }
                case "Shy": 
                    {
                        Button button33 = new();
                        button33.Content = "Give yourself time to take in the situation. Jump in when you're ready!";
                        stackpanel1.Children.Add(button33);
                        Button button34 = new();
                        button34.Content = "Ask someone who is being kind to help you join the game.";
                        stackpanel1.Children.Add(button34);
                        Button button35 = new();
                        button35.Content = "Remember the fun times playing with friends, and that you're sad when you miss out.";
                        stackpanel1.Children.Add(button35);
                        Button button36 = new();
                        button36.Content = "Say to yourself: 'I got this! I can do this!' and GO!! YOU GOT THIS, KIDDO!";
                        stackpanel1.Children.Add(button36);
                        Button button37 = new();
                        button37.Content = "Remember God is always with you to give you strength and courage!";
                        stackpanel1.Children.Add(button37);
                        button33.Click += Button_Click;
                        button34.Click += Button_Click;
                        button35.Click += Button_Click;
                        button36.Click += Button_Click;
                        button37.Click += Button_Click;
                        break;
                    }  
                case "Loved":
                    {
                        Button button38 = new();
                        button38.Content = "Continue to be a wonderful person to others!";
                        stackpanel1.Children.Add(button38);
                        Button button39 = new();
                        button39.Content = "Draw a picture about what made you feel loved or write in a journal.";
                        stackpanel1.Children.Add(button39);
                        Button button40 = new();
                        button40.Content = "Mommy Hug! Or Daddy Hug! Group Hug! Spread the love!";
                        stackpanel1.Children.Add(button40);
                        Button button41 = new();
                        button41.Content = "Think of an idea to spread and share your positive attitude.";
                        stackpanel1.Children.Add(button41);
                        Button button42 = new();
                        button42.Content = "Thank God for all you have!";
                        stackpanel1.Children.Add(button42);
                        button38.Click += Button_Click;
                        button39.Click += Button_Click;
                        button40.Click += Button_Click;
                        button41.Click += Button_Click;
                        button42.Click += Button_Click;
                        break;
                    }  
                case "Proud": 
                    {
                        Button button43 = new();
                        button43.Content = "Tell Mommy and Daddy! We want to celebrate with you!";
                        stackpanel1.Children.Add(button43);
                        Button button44 = new();
                        button44.Content = "Draw a picture about what you did or write in a journal.";
                        stackpanel1.Children.Add(button44);
                        Button button45 = new();
                        button45.Content = "Ask mommy or daddy to take of picture of you and what you are proud of!";
                        stackpanel1.Children.Add(button45);
                        Button button46 = new();
                        button46.Content = "Think of ways to help others with your new skill or idea!";
                        stackpanel1.Children.Add(button46);
                        Button button47 = new();
                        button47.Content = "Thank God for being able to do amazing things with what He gave you!";
                        stackpanel1.Children.Add(button47);
                        button43.Click += Button_Click;
                        button44.Click += Button_Click;
                        button45.Click += Button_Click;
                        button46.Click += Button_Click;
                        button47.Click += Button_Click;
                        break;
                    }
        }//end switch
    }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

                Button b = (Button)sender;

                File.AppendAllLines(@"C:\Users\jenni\OneDrive\CHET_WPF\Tracker.txt", new[] { b.ToString() });

            FeelingsCheckPoint feelingsCheckPoint = new ();
            feelingsCheckPoint.ShowDialog();
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
