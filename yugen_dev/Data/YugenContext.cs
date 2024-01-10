using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using yugen_dev.Models;
using Microsoft.AspNetCore.Identity;

namespace yugen_dev.Data
{
    public class YugenContext : IdentityDbContext<IdentityUser>
    {
        public YugenContext(DbContextOptions<YugenContext> options) :
        base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>()
                .HasOne(c => c.IdentityUser)
                .WithOne()
                .HasForeignKey<Client>(c => c.IdentityUserId);
        }
    }
}