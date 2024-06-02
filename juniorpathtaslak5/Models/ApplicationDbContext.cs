using juniorpathtaslak5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace juniorpathtaslak5
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<DailyData> DailyData { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BERK-PC\\SQLEXPRESS; Database=JuniorPath5DB; User Id=1; Password=1");
        }
    }
}
