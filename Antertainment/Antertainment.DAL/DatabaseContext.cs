using Antertainment.DAL.Entities;

using Microsoft.EntityFrameworkCore;

namespace Antertainment.DAL;

public class DatabaseContext : DbContext
{
    public DbSet<Ant> Ants { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Image> Images { get; set; }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
}
