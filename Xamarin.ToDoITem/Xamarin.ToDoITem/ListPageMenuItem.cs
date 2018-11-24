using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.ToDoITem
{

    public class ListPageMenuItem
    {
        public ListPageMenuItem()
        {
            TargetType = typeof(ListPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}