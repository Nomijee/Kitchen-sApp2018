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
	public partial class burgers : ContentPage
	{
		public burgers ()
		{
			InitializeComponent ();
		}
        private void b1_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void b2_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void b3_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void b4_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void b5_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void back_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new MainPage());
        }
    }
}