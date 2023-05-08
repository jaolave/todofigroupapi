using ToDoFiGroupApi.Models;

namespace ToDoFiGroupApi.Interfaces
{
    public interface IToDoRepository
    {
        Task<IEnumerable<ToDoItem>> GetAllAsync();
        Task<ToDoItem> GetByIdAsync(Guid uid);
        Task AddAsync(ToDoItem toDoItem);
        Task UpdateAsync(ToDoItem toDoItem);
        Task DeleteAsync(Guid uid);
    }
}
