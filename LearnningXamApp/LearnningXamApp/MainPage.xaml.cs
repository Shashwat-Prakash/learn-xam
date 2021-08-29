using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearnningXamApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginBtn(object sender, EventArgs e)
        {
            DisplayAlert("Login",
                string.Format("Login Successfull!!! \nHello {0}, Welcome to Home Page", username.Text), 
                "Ok");
            Navigation.PushAsync(new Home(username.Text));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Pickers", "Welcome to Pickers page", "Ok");
            Navigation.PushAsync(new PickersPage());
        }
    }
}
