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
    public partial class Policies : ContentPage
    {
        public Policies()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}