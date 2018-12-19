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
	public partial class wraps : ContentPage
	{
		public wraps ()
		{
			InitializeComponent ();
		}
        private void w1_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void w2_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void w3_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void w4_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void back_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new MainPage());
        }
    }
}