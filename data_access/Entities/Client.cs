using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using data_access.Entities;

namespace EntityFramerworkCorePD_211.Entities
{
    public class Client
    {
        //foreign key and primary key
        //Id..ID...id...ClientId --primary key
        //Credentials + Id === foreign key
       
        public int Id { get; set; }//not null 
       // public int Id { get; set; }//primary key
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }

        //Navigation properties

        //Relational type : Many to Many (*....*)
        public ICollection<Flight> Flights { get; set; }

        /*one to one*/
      
        public Credentials Credentials { get; set; }//null
    }
}
