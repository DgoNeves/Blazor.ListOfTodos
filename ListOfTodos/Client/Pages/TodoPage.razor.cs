using ListOfTodos.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ListOfTodos.Client.Pages
{
    public class TodoPageBaseComponent : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        public List<TodoItem> TodoItems = new List<TodoItem>
        {
            new TodoItem
            {
                TaskName = "Loading todos",
            },
            new TodoItem
            {
                TaskName = "Loading todos",
            },
            new TodoItem
            {
                TaskName = "Loading todos",
            },

        };

        public TodoItem todoItem = new TodoItem();

        protected override async Task OnInitializedAsync()
        {
            await RefreshTodos();
        }
        
        public async Task RefreshTodos()
        {
            TodoItems = await Http.GetFromJsonAsync<List<TodoItem>>("todo");
            StateHasChanged();
        }

        public async Task AddTodo()
        {
            await Http.PostAsJsonAsync("todo", todoItem);
            todoItem = new TodoItem();

            await RefreshTodos();

        }

        public async void UpdateTodo(TodoItem todoItem)
        {
            await Http.PutAsJsonAsync("todo", todoItem);
            await RefreshTodos();

        }

        public async void KeyUpEnterTodo(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                await AddTodo();
            }
        }

       
    }
}
