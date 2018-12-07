using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.ToDoITem
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddItem : ContentPage
	{
        public ObservableCollection<Task> myList;

		public AddItem ()
		{
			InitializeComponent ();
            myList = new ObservableCollection<Task>();
		}

	    private async void AddButton_OnClicked(object sender, EventArgs e)
	    {
	        if (string.IsNullOrEmpty(TaskEntry.Text))
	        {
	            await DisplayAlert(null, "Cannot add empty task!", "OK");
	            return;
	        }

            var task = new Task
	        {
	            Text = TaskEntry.Text
	        };

	        myList.Add(task);
	        ItemsListView.ItemsSource = myList;

	        TaskEntry.Text = "";
	    }

	    private void ItemsListView_OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        ItemsListView.SelectedItem = null;
	    }
	}
}