using OakIdeas.GenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfTodos.Shared
{
    public class TodoItem : EntityBase
    {
        public string TaskName { get; set; }

        public bool IsDone { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        public DateTime DueDate { get; set; }
    }
}