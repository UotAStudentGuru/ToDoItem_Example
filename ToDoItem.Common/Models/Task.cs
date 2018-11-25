using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ToDoItem.Common.Models
{
    public class Task : BaseModel
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

    }
}
