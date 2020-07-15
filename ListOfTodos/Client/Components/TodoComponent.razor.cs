using ListOfTodos.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListOfTodos.Client.Components
{
    public class TodoComponentBase : ComponentBase
    {
        [Parameter]
        public List<TodoItem> TodoItems { get; set; }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
    }
}