﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramerworkCorePD_211.Entities
{
    public class Airplane
    {
        public int Id { get; set; }//Id int not null
        public string Model { get; set; }//Model nvarchar(max) null
        public int MaxPassanger { get; set; }

        //Navigation properties
        public ICollection<Flight> Flights { get; set; }
    }
}