using Microsoft.EntityFrameworkCore;

namespace FeWo_Verwaltung_Core.Database
{
    public class VerwaltungContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<MietWohnung> MietWohnungen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Verwaltung.db");
    }
}