using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckoutApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPage : ContentPage
    {
        public EditPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Btn_Register_Clicked(object sender, EventArgs e)
        {

        }
    }
}