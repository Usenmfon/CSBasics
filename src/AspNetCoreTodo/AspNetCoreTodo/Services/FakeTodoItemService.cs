using System;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };

            var item2 = new TodoItem
            {
                Title = "Build awesome apps",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };

            var item3 = new TodoItem
            {
                Title = "Zuri Team",
                DueAt = DateTimeOffset.Now.AddDays(3)
            };

            var item4 = new TodoItem
            {
                Title = "Course commence",
                DueAt = DateTimeOffset.Now.AddDays(5)
            };

            return Task.FromResult(new[] { item1, item2, item3, item4 });
        }
    }
}