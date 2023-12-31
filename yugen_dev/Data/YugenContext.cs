using Microsoft.EntityFrameworkCore;
using yugen_dev.Models;

namespace yugen_dev.Data
{
    public class YugenContext : DbContext
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
    }
}