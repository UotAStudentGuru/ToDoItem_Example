using SQLite;

namespace Xamarin.ToDoITem.SQLite
{
    public class ItemDatabase
    {
        readonly SQLiteAsyncConnection database;

        public ItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Task>().Wait();
        }

        public SQLiteAsyncConnection Database
        {
            get { return database; }
        }
    }
}