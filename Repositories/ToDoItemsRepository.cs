using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoFiGroupApi.Data;
using ToDoFiGroupApi.Interfaces;
using ToDoFiGroupApi.Models;

namespace ToDoFiGroupApi.Repositories
{
    public class ToDoItemsRepository : IToDoRepository
    {
        private readonly ToDoDbContext _context;

        public ToDoItemsRepository(ToDoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ToDoItem>> GetAllAsync()
        {
            return await _context.ToDoItems.ToListAsync();
        }

        public async Task<ToDoItem> GetByIdAsync(Guid id)
        {
            return await _context.ToDoItems.FindAsync(id);
        }

        public async Task AddAsync(ToDoItem item)
        {
            item.UID = Guid.NewGuid();
            await _context.ToDoItems.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ToDoItem item)
        {
            _context.ToDoItems.Update(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await _context.ToDoItems.FindAsync(id);
            if (item != null)
            {
                _context.ToDoItems.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}
