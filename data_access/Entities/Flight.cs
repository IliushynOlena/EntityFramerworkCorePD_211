using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramerworkCorePD_211.Entities
{
    public class Flight
    {
        public int Number { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int? Rating { get; set; }//not null....or ...null

        //Navigation properties
        public int AirplaneId { get; set; }//foreign key
        public Airplane Airplane { get; set; }//null

        public ICollection<Client> Clients { get; set; }//null

    }
}
