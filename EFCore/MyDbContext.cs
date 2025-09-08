using Microsoft.EntityFrameworkCore;
using ReceptdatabasÖvning.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore;
public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }

    public DbSet<Dish>? Dish { get; set; } = default!;
    public DbSet<Ingredience>? Ingredience { get; set; } = default!;
}
