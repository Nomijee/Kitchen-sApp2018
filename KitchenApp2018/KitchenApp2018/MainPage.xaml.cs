using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KitchenApp2018
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void menubtn_Clicked(object sender, EventArgs e)
        {
           
            Navigation.PushAsync(new menu());
        }

        private void specialBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new specials());
        }
        private void pizzasBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pizzas());
        }
        private void wrapsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new wraps());
        }
        private void burgersBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new burgers());
        }
        private void desertsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new deserts());
        }


    }
}
