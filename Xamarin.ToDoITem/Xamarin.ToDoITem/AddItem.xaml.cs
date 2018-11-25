using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<TasksClass> myList;
		public AddItem ()
		{
			InitializeComponent ();
            myList = new ObservableCollection<TasksClass>();
		}

        public void addbutton(object sender, EventArgs e)
        {
            var myObj = new TasksClass
            {
                Task = TaskEntry.Text
            };
            myList.Add(myObj);
            listviewObject.ItemsSource = myList;
        }
    }
}