using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckoutApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notifications : ContentPage
    {
        public Notifications()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
        }

        private void Switch_Toggled_1(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
        }

        private void Switch_Toggled_2(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
        }

        private void Switch_Toggled_3(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
        }
    }
}