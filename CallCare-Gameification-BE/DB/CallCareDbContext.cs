using Microsoft.EntityFrameworkCore;
using CallCare_Gameification_BE.Models;

namespace CallCare_Gameification_BE.DB
{
    public class callcareDB : DbContext
    {
        public callcareDB(DbContextOptions<callcareDB> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserID);
                entity.Property(e => e.Username).HasMaxLength(100);
            });
        }
    }
}
