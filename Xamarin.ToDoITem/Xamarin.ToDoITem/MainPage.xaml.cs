using System;
using Xamarin.Forms;

namespace Xamarin.ToDoITem
{
	public partial class MainPage : ContentPage
	{
	    string default_name = "admin";
	    string default_password = "admin";

        public MainPage()
		{
			InitializeComponent();
		    NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
	    {
	        Username.Text = "";
	        Password.Text = "";
        }

	    private async void Login_Clicked(object sender, EventArgs e)
        {
            if (Username.Text == default_name && Password.Text == default_password)
                await Navigation.PushAsync(new AddItem());
            else
                await DisplayAlert(null, "Wrong username or password!", "OK");
        }
    }
}