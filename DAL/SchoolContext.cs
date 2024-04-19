using Microsoft.EntityFrameworkCore;
using Model;

namespace DAL
{
    public class SchoolContext : DbContext
    {
        // Konstruktor przyjmujący DbContextOptions
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        // DbSets
        public DbSet<Student> Studenci { get; set; }
        public DbSet<Grupa> Groupy { get; set; }
        public DbSet<Historia> Historie { get; set; }

        // Usuń metodę OnConfiguring jeśli konfiguracja ma być przekazywana przez DI
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     if (!optionsBuilder.IsConfigured)
        //     {
        //         optionsBuilder.UseSqlServer("YourConnectionStringHere");
        //     }
        // }
    }
}
