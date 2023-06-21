using Microsoft.EntityFrameworkCore;
using Models;

namespace EfCoreCodeFirst.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
