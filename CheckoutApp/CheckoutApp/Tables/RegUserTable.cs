using SQLite;
using System;
using Xamarin.Forms.Xaml;



namespace CheckoutApp.Tables
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class RegUserTable
    {
        [PrimaryKey, AutoIncrement]
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
