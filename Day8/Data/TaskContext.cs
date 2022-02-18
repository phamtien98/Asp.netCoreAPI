using Microsoft.EntityFrameworkCore;
using Day8.Entities;
namespace Day8.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options)
          : base(options) { }
        public DbSet<TaskModel> Tasks { get; set; }
    }
}