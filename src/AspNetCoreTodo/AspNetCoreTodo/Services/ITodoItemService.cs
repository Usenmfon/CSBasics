using System.Threading.Tasks;
using Models;

namespace Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteAsync();
    }
}