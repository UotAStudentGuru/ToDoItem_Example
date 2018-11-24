using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.ToDoITem
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            String default_name ="admin";
            String default_password = "admin";
            if(username.Text.Equals(default_name) && password.Text.Equals(default_password))
            {
                await this.Navigation.PushAsync(new ListPage(),true);
            }
            else
            {
                error.Text = "Wrong Username/Password Combination";
            }
        }
    }
}
