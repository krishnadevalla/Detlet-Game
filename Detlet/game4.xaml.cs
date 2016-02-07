using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Detlet
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class game4 : Page
    {
        int score=100;
        int click = 0;
        public game4()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            score += (int)e.Parameter;

        }

        private void nutbtn_Click(object sender, RoutedEventArgs e)
        {
            nutbtn.Visibility = Visibility.Collapsed;
            mixbtn.Visibility = Visibility.Visible;
            nutplace.Begin();

        }

        private void mixbtn_Click(object sender, RoutedEventArgs e)
        {
            Random rn = new Random();
            int a = rn.Next(1, 10);
            if (a == 1)
            {
                mix1.Begin();
            }
            else if (a == 2)
            {
                mix2.Begin();
            }
            else if (a == 3)
            {
                mix3.Begin();
            }
            else if (a == 4)
            {
                mix4.Begin();
            }
            else if (a == 5)
            {
                mix5.Begin();
            }
            else if (a == 6)
            {
                mix6.Begin();
            }
            else if (a == 7)
            {
                mix7.Begin();
            }
            else if (a == 8)
            {
                mix8.Begin();
            }
            else if (a == 9)
            {
                mix9.Begin();
            }
            else if (a == 10)
            {
                mix10.Begin();
            }

            mixbtn.Visibility = Visibility.Collapsed;
            nut.Visibility = Visibility.Collapsed;
        }

        private void img4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            click++;
            score = score - 10;
            img4.Visibility = Visibility.Collapsed;
            nut4.Margin = img4.Margin;
            nut4.Visibility = Visibility.Visible;
            scoretxt.Text = "Negitive score";
            if (click == 2)
            {
                replay.Visibility = Visibility.Visible;
            }
            else
            {
                scoretxt.Text = "Try again!! Choose another";
            }

        }

        private void img3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            click++;
            score = score - 20;
            img3.Visibility = Visibility.Collapsed;
            nut3.Margin = img3.Margin;
            nut3.Visibility = Visibility.Visible;
            scoretxt.Text = "Negitive score";
            if (click == 2)
            {
                replay.Visibility = Visibility.Visible;
            }
            else
            {
                scoretxt.Text = "Try again!! Choose another";
            }
        }

        private void img2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            click++;
            score = score - 20;
            img2.Visibility = Visibility.Collapsed;
            nut2.Margin = img2.Margin;
            nut2.Visibility = Visibility.Visible;
            scoretxt.Text = "Negitive score";
            if (click == 2)
            {
                replay.Visibility = Visibility.Visible;
            }
            else
            {
                scoretxt.Text = "Try again!! Choose another";
            }
        }

        private void img1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            scoretxt.Text = "Score: " + score.ToString();
            img1.Visibility = Visibility.Collapsed;
            nut.Margin = img1.Margin;
            nut.Visibility = Visibility.Visible;
            next.Visibility = Visibility.Visible;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(scorepage), score);
        }

        private void replay_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }

        private void goit_Click_1(object sender, RoutedEventArgs e)
        {
            show.Visibility = Visibility.Collapsed;
            mixmedia.Play();
        }
    }
}
