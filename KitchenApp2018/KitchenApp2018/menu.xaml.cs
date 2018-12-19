using SQLite;
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
	public partial class menu : ContentPage
	{
        public SQLiteConnection cart;
		public menu ()
		{
			InitializeComponent ();
		}

        private void p1_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void p2_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
        private void p3_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new menu());
        }
    }
}