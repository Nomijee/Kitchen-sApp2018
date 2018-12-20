using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KitchenApp2018
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class loginPage : ContentPage
    {
        public loginPage()
        {
            InitializeComponent();
        }
        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // should be enter with email and password 
            bool isUserEmpty, isPwdEmpty;
            isUserEmpty = String.IsNullOrEmpty(usernameEntry.Text);
            isPwdEmpty = String.IsNullOrEmpty(passwordEntry.Text);
            if (isUserEmpty || isPwdEmpty)
            {
                DisplayAlert("Error", "Email or Password cannot be empty", "Try Again");
            }
            //then go to main page  
            else
            {
                Navigation.PushAsync(new MainPage());
            } 
        }
    }
}