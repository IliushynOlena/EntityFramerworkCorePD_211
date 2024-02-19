using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramerworkCorePD_211.Entities
{
    //Entities
    [Table("Passangers")]
    public class Client
    {
        public int Id { get; set; }
        [Required]//null ---> not null
        [MaxLength(100)]//nvarchar(100)
        [Column("FirstName")]//set column name
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }//not null ===> null

        //Navigation properties

        //Relational type : Many to Many (*....*)
        public ICollection<Flight> Flights { get; set; }
    }
}
