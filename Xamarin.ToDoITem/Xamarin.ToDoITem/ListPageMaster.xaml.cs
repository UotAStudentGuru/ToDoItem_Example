using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.ToDoITem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPageMaster : ContentPage
    {
        public ListView ListView;

        public ListPageMaster()
        {
            InitializeComponent();


            BindingContext = new ListPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class ListPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ListPageMenuItem> MenuItems { get; set; }
            
            public ListPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<ListPageMenuItem>(new[]
                {
                    new ListPageMenuItem { Id = 0, Title = "Add Item", TargetType=typeof(AddItem)  },
                    new ListPageMenuItem { Id = 1, Title = "Logout", TargetType=typeof(MainPage) },
                    
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}