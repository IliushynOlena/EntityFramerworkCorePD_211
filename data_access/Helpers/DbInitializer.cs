using data_access.Entities;
using EntityFramerworkCorePD_211.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramerworkCorePD_211.Helpers
{
    public static class DbInitializer
    {
        //Extension method
        public static void SeedAirplanes(this ModelBuilder modelBuilder)
        {
            //Initializator - Seeder
            modelBuilder.Entity<Airplane>().HasData(new Airplane[]
             {
                new Airplane()
                {
                    Id = 1,
                    Model = "Boing747",
                    MaxPassanger = 300
                },
                new Airplane()
                {
                    Id = 2,
                    Model = "AN914",
                    MaxPassanger = 200
                },
                new Airplane()
                {
                    Id = 3,
                    Model = "Mria",
                    MaxPassanger = 150
                }
             });

        }
        public static void SeedFlights(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>().HasData(new Flight[] {
                new Flight()
                {
                     Number = 1,
                     DepartureCity = "Kyiv",
                     ArrivalCity = "Lviv",
                     DepartureTime = new DateTime(2024,2,17),
                     ArrivalTime = new DateTime(2024,2,17),
                     AirplaneId = 1
                },
                new Flight()
                {
                     Number = 2,
                     DepartureCity = "Varshava",
                     ArrivalCity = "Lviv",
                     DepartureTime = new DateTime(2024,2,18),
                     ArrivalTime = new DateTime(2024,2,18),
                     AirplaneId = 2
                },
                new Flight()
                {
                     Number = 3,
                     DepartureCity = "Kyiv",
                     ArrivalCity = "Lviv",
                     DepartureTime = new DateTime(2024,2,22),
                     ArrivalTime = new DateTime(2024,2,22),
                     AirplaneId = 3
                }
            });
        }

        public static void SeedCredentials(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Credentials>().HasData(new Credentials[]
            {
                new Credentials()
                {
                     Id = 1,
                     Login = "admin",
                     Password = "admin"
                },
                new Credentials()
                {
                     Id = 2,
                     Login = "user",
                     Password = "user"
                },
                new Credentials()
                {
                     Id = 3,
                     Login = "designer",
                     Password = "designer"
                }
            });
        }
        public static void SeedClients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(new Client[]
           {
                new Client()
                {
                      Id = 1, 
                      Name = "Victor",
                      Birthday = new DateTime(2000,5,12),
                      Email = "victor@gmail.com" 
                },
                new Client()
                {
                      Id = 2,
                      Name = "Ivanka",
                      Birthday = new DateTime(2005,5,25),
                      Email = "ivanka@gmail.com"
                },
                new Client()
                {
                     Id = 3,
                      Name = "Oleg",
                      Birthday = new DateTime(2001,5,12),
                      Email = "oleg@gmail.com"
                }
           });
        }
       
    }
}
