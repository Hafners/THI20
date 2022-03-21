using Microsoft.EntityFrameworkCore;
using XrmRestApi.Data;

namespace XrmRestApi
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        public DbSet<Hafner_Customer> HafnerCustomers { get; set; }
    }
}
