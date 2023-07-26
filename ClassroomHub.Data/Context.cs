using Microsoft.EntityFrameworkCore;

namespace ClassroomHub.Data
{
    public class Context : DbContext
    {
        private readonly string _connString;

        public Context(DbContextOptions options) : base(options)
        {
        }

        public Context(DbContextOptions options,string connString) : this(options)
        {
            _connString = connString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(_connString))
            {
                optionsBuilder.UseSqlServer(_connString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
        }
    }
}
