using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfTodos.Shared
{
    public class TodoItem
    {
        public string Name { get; set; }

        public bool IsDone { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime DueDate { get; set; }
    }
}