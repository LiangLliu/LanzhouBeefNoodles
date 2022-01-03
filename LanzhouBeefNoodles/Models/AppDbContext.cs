using Microsoft.EntityFrameworkCore;

namespace LanzhouBeefNoodles.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Noodle> Noodles { set; get; }
        public DbSet<Feedback> Feedbacks { set; get; }
    }
}