using System;
#pragma warning disable IDE0005 // Using directive is unnecessary.

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;
using System.Data.SQLite;

namespace CheckoutApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanPage : ContentPage
    {
        public ScanPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        SQLiteConnection myconnection = new SQLiteConnection(@"Data Source= C:\Users\bhumi\OneDrive\Desktop\ComIT\ImageDatabase\ImageTB; 
                                      version = 3; New = True;");
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var scan = new ZXingScannerPage();
            await Navigation.PushAsync(scan);
            scan.OnScanResult += (result) =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    MyList.Text = result.Text;
                });
            };

        }
                 
     }
}
