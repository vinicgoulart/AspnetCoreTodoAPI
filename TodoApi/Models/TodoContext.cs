using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> option)
            : base(option) { }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
