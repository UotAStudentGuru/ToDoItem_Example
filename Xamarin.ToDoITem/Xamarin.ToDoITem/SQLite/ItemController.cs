using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace Xamarin.ToDoITem.SQLite
{
    public class ItemController
    {
        public readonly SQLiteAsyncConnection database;

        public ItemController()
        {
            database = App.ItemDatabase.Database;
            database.GetConnection();
        }

        public Task<List<Task>> GetTasks()
        {
            return database.Table<Task>().ToListAsync();
        }

        public Task<int> InsertTask(Task task)
        {
            return database.InsertAsync(task);
        }

        public Task<int> DeleteTask(Task task)
        {
            return database.DeleteAsync(task);
        }
    }
}