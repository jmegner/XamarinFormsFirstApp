using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // This is optional, but provides better layout for the iPhone X 
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        int count = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }

        private void WelcomeLabel_Tapped(object sender, EventArgs e)
        {
            // google for "xaml label clicked", https://www.google.com/search?client=firefox-b-1-d&q=xaml+label+clicked
            // visit result "Click Label - Xamarin Community Forums", https://forums.xamarin.com/discussion/82190/click-label
            // follow link in answer, scroll down to comment with code snippet, https://forums.xamarin.com/discussion/comment/60564/#Comment_60564

            ((Label)sender).Text += "!";
        }
    }
}
