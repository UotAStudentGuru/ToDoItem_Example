using System.IO;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.ToDoITem.SQLite;

namespace Xamarin.ToDoITem.Droid
{
    [Activity(Label = "Xamarin.ToDoITem", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Forms.Platform.Android.FormsAppCompatActivity, ISqliteManage
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Forms.Forms.Init(this, bundle);
            SQLitePCL.Batteries_V2.Init();

            App.Init(this);
            LoadApplication(new App());
        }

        public string DatabaseFolder()
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "ToDoItemSQLite.db3");
        }
    }
}