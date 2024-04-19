using Microsoft.EntityFrameworkCore;
using Model;

namespace DAL
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grupa> Grupy { get; set; }
        public DbSet<Historia> Historia { get; set; } // Poprawiona nazwa właściwości

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Konfiguracja dla Student
            modelBuilder.Entity<Student>()
                .HasKey(s => s.ID);

            modelBuilder.Entity<Student>()
                .HasOne<Grupa>(s => s.Grupa)
                .WithMany(g => g.Studenci)
                .HasForeignKey(s => s.IDGrupy)
                .OnDelete(DeleteBehavior.Cascade); // Zmiana akcji referencyjnej na CASCADE

            // Konfiguracja dla Grupa
            modelBuilder.Entity<Grupa>()
                .HasKey(g => g.ID);

            modelBuilder.Entity<Grupa>()
                .HasMany<Student>(g => g.Studenci)
                .WithOne(s => s.Grupa)
                .HasForeignKey(s => s.IDGrupy)
                .OnDelete(DeleteBehavior.SetNull); // Zachowanie opcjonalne, ale rekomendowane
        }

    }
}
