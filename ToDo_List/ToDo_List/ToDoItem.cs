using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List
{
    internal class ToDoItem
    {
        public string text;
        public bool done;

        public ToDoItem(string text, bool done)
        {
            this.text = text;
            this.done = done;
        }
    }
}
