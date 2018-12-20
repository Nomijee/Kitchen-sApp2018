using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace KitchenApp2018
{
    public class SplashScreen: ContentPage
    {
        Image splash_pic;
        public SplashScreen()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var lay = new AbsoluteLayout();
            splash_pic = new Image
            {
                Source = "splashImage.png",
                WidthRequest = 200,
                HeightRequest = 200
            };
            AbsoluteLayout.SetLayoutFlags(splash_pic, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splash_pic, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            lay.Children.Add(splash_pic);
            this.BackgroundColor = Color.Red;
            this.Content = lay;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await splash_pic.FadeTo(0, 3000);
            await splash_pic.FadeTo(1, 1000);
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
