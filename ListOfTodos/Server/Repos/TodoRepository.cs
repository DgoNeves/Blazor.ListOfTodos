using ListOfTodos.Shared;
using OakIdeas.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListOfTodos.Server.Repos
{
    public class TodoRepository :  MemoryGenericRepository<TodoItem>, IGenericRepository<TodoItem>
    {
    }
}
