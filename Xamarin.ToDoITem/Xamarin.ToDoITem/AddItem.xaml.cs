using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.ToDoITem
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddItem : ContentPage
	{
		public AddItem ()
		{
			InitializeComponent ();
		}

        public void Add_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}