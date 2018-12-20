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
        private void OnSignUpButtonClicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new MainPage());
        }
        private void OnLoginButtonClicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new MainPage());
        }
    }
}