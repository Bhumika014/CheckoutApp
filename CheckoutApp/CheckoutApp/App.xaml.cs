using CheckoutApp.View;
using Xamarin.Forms;

namespace CheckoutApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
