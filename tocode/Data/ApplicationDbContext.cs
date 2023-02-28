using Microsoft.EntityFrameworkCore;
using tocode.Models;

namespace tocode.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }
    public DbSet<Category> Categories {get; set;}
    
}