using Microsoft.EntityFrameworkCore;
using ToDoFiGroupApi.Models;

namespace ToDoFiGroupApi.Data
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        {
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>(entity =>
            {
                entity.HasKey(e => e.UID);
            });
        }
    }
}
