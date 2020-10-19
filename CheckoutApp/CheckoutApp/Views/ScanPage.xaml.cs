using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Net.Mobile.Forms;


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


        SQLiteConnection myconnection = new SQLiteConnection("Data Source = C:/Users/bhumi/source/repos/CheckoutApp/images.db; version = 3");

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
        myconnection.Open();
        SQLiteCommand cmd = new SQLiteCommand();
        cmd.Command = myconnection;
        cmd.CommandText = "Select Name From ImgTB where Barcode="Result";
        myconnection.Open();
        Command = new SQLiteCommand();
        using {(SQLiteDataReader reader = Command.ExecuteReader()) ;}




          
     }
}
