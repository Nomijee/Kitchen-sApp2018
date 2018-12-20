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
       
		public menu ()
		{
			InitializeComponent ();
		}
        private void addBtn_Clicked(object sender, EventArgs e)
        {
            // enter quantity to add
            bool isUserEmpty;
            isUserEmpty = String.IsNullOrEmpty(quntity.Text);
            
            if (isUserEmpty)
            {
                DisplayAlert("Error", "Please enter Quntity", "Atleast One");
            }
            else
            {
                Navigation.PushAsync(new MainPage());
            }
        }
        private void delBtn_Clicked(object sender, EventArgs e)
        {
            // enter quantity to delete
            bool isUserEmpty;
            isUserEmpty = String.IsNullOrEmpty(quntity.Text);

            if (isUserEmpty)
            {
                DisplayAlert("Error", "Please enter Quntity to Remove", "Atleast One");
            }
            else
            {
                Navigation.PushAsync(new MainPage());
            }
        }
        private void conBtn_Clicked(object sender, EventArgs e)
        {
            //to confirm order

            Navigation.PushAsync(new MainPage());
        }
        

    }
}