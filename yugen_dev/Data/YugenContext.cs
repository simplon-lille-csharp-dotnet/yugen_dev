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
        public DbSet<Dish> Dishes { get; set; }

    }

}