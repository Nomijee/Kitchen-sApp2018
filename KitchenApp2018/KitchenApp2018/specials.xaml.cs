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
	public partial class specials : ContentPage
	{
		public specials ()
		{
			InitializeComponent ();
		}
        private void s1_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void s2_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void s3_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void back_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new MainPage());
        }


    }
}