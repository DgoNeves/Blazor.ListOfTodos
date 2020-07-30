using OakIdeas.GenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfTodos.Shared
{
    public class TodoItem : EntityBase
    {
        public string ItemName { get; set; }

        public bool IsDone { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime DueDate { get; set; } = DateTime.UtcNow;
    }
}
