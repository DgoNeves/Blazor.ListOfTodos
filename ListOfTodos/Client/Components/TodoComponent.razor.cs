using ListOfTodos.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ListOfTodos.Client.Components
{
    public class TodoComponentBase : ComponentBase
    {
        [CascadingParameter(Name = "TodoItem")]
        public TodoItem TodoItem { get; set; }

        [Parameter]
        public EventCallback<TodoItem> UpdateCallback { get; set; }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

    }
}