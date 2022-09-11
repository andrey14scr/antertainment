using Microsoft.EntityFrameworkCore;

namespace Antertainment.DAL;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
}
