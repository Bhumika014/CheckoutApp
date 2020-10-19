using CheckoutApp.ViewModel;

using System.Linq;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckoutApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyListPage : ContentPage
    {
        public MyListPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = new MyListViewModel();
        }
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            var _container = BindingContext as MyListViewModel;
            ProductListView.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                ProductListView.ItemsSource = _container.MyListCollector;
            else
                ProductListView.ItemsSource = _container.MyListCollector.Where(i => i.MyName.Contains(e.NewTextValue));

            ProductListView.EndRefresh();
        }


        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var _container = BindingContext as MyListViewModel;
            //do work over here
            DisplayAlert("Sucess", "Item Added to the cart", "OK", "Cancel");
        }
    }
}