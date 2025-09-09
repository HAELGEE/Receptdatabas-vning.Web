using Microsoft.EntityFrameworkCore;
using ReceptdatabasÖvning.Web;

namespace EFCore;
public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }

    public DbSet<Dish>? Dish { get; set; } = default!;
    public DbSet<Ingredience>? Ingredience { get; set; } = default!;
    
}
