using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Xamarin.Forms.Xaml;
using NavigationPage = Xamarin.Forms.NavigationPage;

namespace CheckoutApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserDetail : ContentPage
    {
        public UserDetail()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            PaymentClickFunc();
            SettingsClickFunc();
            HeplClickFunc();
            FaqClickFunc();
            
        }

        private async void TakePhotoButton_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable
                  || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("NOCamera", ":(NO Camera Available.", "Ok");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(
                new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    SaveToAlbum = true,
                });
            if (file == null)
                return;
            PathLabel.Text = file.AlbumPath;

            MainImage.Source = ImageSource.FromStream(() =>
            {
                var strem = file.GetStream();
                file.Dispose();
                return strem;
            });
        }
        private async void PickPhotoButton_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Ooops", "Pick Photo is not supported !", "Ok");
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync();

            if (file == null)
                return;

            PathLabel.Text = "Photo Path" + file.Path;

            MainImage.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;

            });

        }
        void PaymentClickFunc()
        {
            PaymentClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(async () =>
                {
                    await Navigation.PushAsync(new PaymentPage());
                }
                )
            });
        }

        void SettingsClickFunc()
        {
            SettingsClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(async () =>
                {
                    await Navigation.PushAsync(new SettingsPage());
                }
                )
            });
        }
        void HeplClickFunc()
        {
            HelpClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    DisplayAlert("Hello", "you clicked on Help", "OK");
                }
                )
            });
        }

        void FaqClickFunc()
        {
            FaqClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    DisplayAlert("Hello", "you clicked on FAQ", "OK");
                }
                )
            });
        }


        async void Handle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

    }
}