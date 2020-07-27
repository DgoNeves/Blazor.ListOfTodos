using ListOfTodos.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListOfTodos.Client.Pages
{
    public class TodoPageBaseComponent : ComponentBase
    {
        public TodoItem todoItem = new TodoItem();

        public void AddTodo()
        {
            todos.Add(todoItem);
            todoItem = new TodoItem();
        }

        public void KeyUpEnterTodo(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                AddTodo();
            }
        }

        public List<TodoItem> todos = new List<TodoItem>
        {
            new TodoItem
            {
                TaskName = "My first todo",
                CreateDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(2),
                IsDone = false
            },
            new TodoItem
            {
                TaskName = "My second todo",
                CreateDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(2),
                IsDone = false
            },
            new TodoItem
            {
                TaskName = "My third todo",
                CreateDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(3),
                IsDone = false
            },

        };
    }
}
