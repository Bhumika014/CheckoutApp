using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckoutApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentPage : ContentPage
    {
        public PaymentPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        //Add Payment method
        private void Btn_Register_Clicked(object sender, EventArgs e)
        {

        }
        //Other Paymet method
        private void Btn_Register1_Clicked(object sender, EventArgs e)
        {

        }
    }
}