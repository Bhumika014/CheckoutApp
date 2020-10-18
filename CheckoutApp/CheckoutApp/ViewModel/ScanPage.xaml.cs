using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;
using ZXing.QrCode.Internal;

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

        public SQLiteCommand Command { get; private set; }

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

            SQLiteConnection myconnection = new SQLiteConnection("Data Source = C:/Users/bhumi/source/repos/CheckoutApp/images.db; version = 3");
            myconnection.Open();
            String query ="Select Barcode From ImgTB";
            myconnection.Open();
            Command = new SQLiteCommand();

            using (SQLiteDataReader reader = Command.ExecuteReader()) ;





        }
                 
     }
}
