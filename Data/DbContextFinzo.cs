using Finzo.Models;
using Microsoft.EntityFrameworkCore;

namespace Finzo.Data
{
    public class DbContextFinzo : DbContext
    {
        public DbContextFinzo() { }
        public DbContextFinzo(DbContextOptions<DbContextFinzo> options) : base(options) { }

        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                   .HasKey(user => user.Id);
        }      
      
    }
}
