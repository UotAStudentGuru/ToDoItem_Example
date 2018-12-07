using Xamarin.Forms;
using Xamarin.ToDoITem.SQLite;

namespace Xamarin.ToDoITem
{
	public partial class App : Application
	{
	    public static ItemDatabase ItemDatabase { get; set; }
        public static ISqliteManage SqliteManage { get; set; }
	    public static ItemController ItemController { get; set; }

        public App ()
		{
			InitializeComponent();

		    ItemDatabase = new ItemDatabase(SqliteManage.DatabaseFolder());
		    ItemController = new ItemController();

            MainPage = new NavigationPage(new MainPage());
		}

	    public static void Init(ISqliteManage sqliteManage)
	    {
	        SqliteManage = sqliteManage;
	    }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}