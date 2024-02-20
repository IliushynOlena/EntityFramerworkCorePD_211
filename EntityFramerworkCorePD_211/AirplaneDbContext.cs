using EntityFramerworkCorePD_211.Entities;
using EntityFramerworkCorePD_211.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramerworkCorePD_211
{
    public class AirplaneDbContext : DbContext
    {
        public AirplaneDbContext()
        {
            //this.Database.EnsureDeleted();
            //this.Database.EnsureCreated();

        }
        //Collections
        public DbSet<Client> Clients { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-3HG9UVT\SQLEXPRESS;
                                        Initial Catalog = NewAirplanePD211;
                                        Integrated Security=True;
                                        Connect Timeout=2;Encrypt=False;
                                         Trust Server Certificate=False;
                                        Application Intent=ReadWrite;Multi Subnet Failover=False"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Fluent API configuration
            modelBuilder.Entity<Airplane>()
                .Property(a=>a.Model)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Client>().ToTable("Passangers");
            modelBuilder.Entity<Client>()
                .Property(c => c.Name)
                .IsRequired()//not null
                .HasMaxLength(100)//nvarchar(100)
                .HasColumnName("FirstName");

            modelBuilder.Entity<Client>()
              .Property(c => c.Email)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Flight>().HasKey(f => f.Number);
            modelBuilder.Entity<Flight>()
             .Property(c => c.DepartureCity)
             .IsRequired()
             .HasMaxLength(100);
            modelBuilder.Entity<Flight>()
             .Property(c => c.ArrivalCity)
             .IsRequired()
             .HasMaxLength(100);

            /*One to many  (1.....*)   */
            modelBuilder.Entity<Flight>()
                .HasOne(f => f.Airplane)
                .WithMany(a => a.Flights)
                .HasForeignKey(a => a.AirplaneId);
            /*Many to many  (*.....*)   */
            modelBuilder.Entity<Flight>()
                .HasMany(f => f.Clients)
                .WithMany(c => c.Flights);

            modelBuilder.SeedAirplanes();
            modelBuilder.SeedFlights();
          
          
        }

    }
}
