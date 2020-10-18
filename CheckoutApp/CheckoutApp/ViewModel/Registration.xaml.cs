using CheckoutApp.Tables;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckoutApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

            var item = new RegUserTable()
            {
                FirstName = EntryFirstName.Text,
                LastName = EntryLastName.Text,
                Email = EntryEmail.Text,
                ContactNumber = EntryContactNumber.Text,
                Address = EntryAddress.Text,
                Username = EntryUsername.Text,
                Password = EntryPassword.Text,
            };
            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Congratulation", "User Register Successfull", "Yes", "Cancle");

                if (result)
                await Navigation.PushAsync(new LoginPage() );
                
                else
                
                    await this.DisplayAlert("Login", "Username or Password is not Correct", "Ok");
                
            });


        }
    }
}