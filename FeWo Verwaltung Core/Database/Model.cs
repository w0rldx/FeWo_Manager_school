using Microsoft.EntityFrameworkCore;

namespace FeWo_Verwaltung_Core.Database
{
    public class VerwaltungContext : DbContext
    {
        //User
        public DbSet<User> Users { get; set; }
        public DbSet<Mieter> Mieter { get; set; }
        public DbSet<Vermierter> Vermierter { get; set; }
        
        //Wohnungen
        public DbSet<MietWohnung> MietWohnungen { get; set; }
        
        //Buchungen
        public DbSet<Vermietet> VermietetSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Verwaltung.db");
    }
}