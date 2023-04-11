﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.Traversal.Entity.Concrete
{
    public class Reservation
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int PersonCount { get; set; }
        public string Destination { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Description  { get; set; }
        public bool Status { get; set; }
    }
}
