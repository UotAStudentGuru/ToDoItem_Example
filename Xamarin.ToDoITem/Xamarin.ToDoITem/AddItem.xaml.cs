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
		}

	    protected override async void OnAppearing()
	    {
	        var list = await App.ItemController.GetTasks();
	        myList = new ObservableCollection<Task>(list);
	        ItemsListView.ItemsSource = myList;
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
	        await App.ItemController.InsertTask(task);
	        ItemsListView.ItemsSource = myList;

	        TaskEntry.Text = "";
	    }

	    private async void ItemsListView_OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        var task = (Task) ItemsListView.SelectedItem;
            ItemsListView.SelectedItem = null;

	        if (await DisplayAlert(null, "Delete selected task?", "Yes", "No"))
	        {
	            myList.Remove(task);
                await App.ItemController.DeleteTask(task);
	            ItemsListView.ItemsSource = myList;
            }
        }
	}
}