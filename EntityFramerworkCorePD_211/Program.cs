using EntityFramerworkCorePD_211.Entities;

using Microsoft.EntityFrameworkCore;

namespace EntityFramerworkCorePD_211
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////value types = not null in database
            int? a = null;
            //int b = 0;//not null
            //DateTime day = null;
            //DateTime date = new DateTime(2000, 3, 6);//not null
            ////references type = null in database
            //string name = null;
            //AirplaneDbContext c = null;
            AirplaneDbContext context = new AirplaneDbContext();
            //context.Clients.Add(new Client()
            //{
            //    Name = "Volodia",
            //    Birthday = new DateTime(2006, 12, 4),
            //    Email = "volodia@gmail.com"
            //});
            //context.SaveChanges();

            //foreach (var item in context.Clients)
            //{
            //    Console.WriteLine($"Client : name - {item.Name}. Email:  " +
            //        $"{item.Email}. Birthday :" +
            //        $"{item.Birthday?.ToShortDateString()} ");
            //}
            //Linq to Entities

            //Loading data : Include(relation data)
            //                     select * from Flights join Aiplane on f.AirplaneId=a.Id
            var filteredFlights = context.Flights.Include(f=>f.Airplane)
                                    .Where(f => f.ArrivalCity == "Lviv")
                                    .OrderBy(f => f.DepartureTime);

            foreach (var f in filteredFlights)
            {
                Console.WriteLine($"Flight : {f.Number}. " +
                    $"From : {f.DepartureCity,-10} " +
                    $"to {f.ArrivalCity,7}  " +
                    $"Date :{f.DepartureTime.ToShortDateString(),10}  " +
                    $"Aiplane : {f.AirplaneId} - {f.Airplane?.Model} Count Pass " +
                    $": {f.Airplane?.MaxPassanger}");

            }
            ///Explicit data loading : context.Entry(entity).Collection/Reference().Load();
            var client = context.Clients.Find(3);
            context.Entry(client).Collection(c=>c.Flights).Load();
            Console.WriteLine($"Client : {client.Name} ." +
                $" Count flights : {client.Flights.Count}");

            foreach (var f in client.Flights)
                Console.WriteLine($"{f.DepartureCity} ====> {f.ArrivalCity} ");


            //if (client != null)
            //{
            //    context.Clients.Remove(client);
            //    context.SaveChanges();
            //}


            //foreach (var f in context.Flights)
            //{
            //    Console.WriteLine($"Flight : {f.Number} From : {f.DepartureCity,15} " +
            //        $"to {f.ArrivalCity}  Rating : {f.Rating}");
            //}

        }
    }
}
