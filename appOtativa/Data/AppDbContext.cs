using Microsoft.EntityFrameworkCore;

namespace appOtativa.Data;
using Models;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<TodoItem> TodoItems { get; set; } 

}