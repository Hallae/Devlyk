using Devlyk.Models;
using Microsoft.EntityFrameworkCore;

namespace Devlyk.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<Devlykerz> Devlykerz { get; set;}
    }
}
