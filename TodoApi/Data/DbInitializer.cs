using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Data
{
    public class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();
            //context.Database.EnsureDeleted();
            //context.Database.Migrate();
            var Todos = new TodoItem[]{
                    new TodoItem
                    {
                        Name = "Clen the house",
                        IsComplete = false,
                    },
                    new TodoItem
                    {
                        Name = "Feed dogs",
                        IsComplete = false,
                    },
                    new TodoItem
                    {
                        Name = "Play guitar",
                        IsComplete = false,
 
                    },
                };
            foreach (TodoItem todo in Todos)
            {
                context.TodoItems.Add(todo);
            }
            context.SaveChanges();
        }
    }
}
