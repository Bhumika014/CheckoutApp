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
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            EditProfileClickFunc();
            NotificationClickFunc();
            PoliciesClickFunc();
            FeedbackClickFunc();
        }
        void EditProfileClickFunc()
        {
            EditProfileClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    DisplayAlert("Hello", "You clicked on Edit Profile", "OK");
                }
                )
            });
        }

        void NotificationClickFunc()
        {
            NotificationClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    DisplayAlert("Hello", "You clicked on Policies", "OK");
                }
                )
            });
        }

       
        void PoliciesClickFunc()
        {
            PoliciesClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    DisplayAlert("Hello", "You clicked on Policies", "OK");
                }
                )
            });
        }

        void FeedbackClickFunc()
        {
            FeedbackClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    DisplayAlert("Hello", "You clicked on Feedback", "OK");
                }
                )
            });
        }
    }
}