using CheckoutApp.Views;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckoutApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WecomePage : ContentPage
    {
        public WecomePage()
        {
            InitializeComponent();
                  NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScanPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyListPage());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserDetail());
        }
    }
}