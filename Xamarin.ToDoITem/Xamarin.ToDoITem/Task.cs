using SQLite;

namespace Xamarin.ToDoITem
{
    public class Task
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        public string Text { get; set; }
    }
}