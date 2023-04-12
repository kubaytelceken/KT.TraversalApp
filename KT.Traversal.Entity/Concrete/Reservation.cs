using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }

        public DateTime ReservationDate { get; set; }
        public string Description  { get; set; }
        public int Status { get; set; }
        [NotMapped]
        public string StatuStr { get; set; }

        public Reservation()
        {
            StatuStr = Status == 0 ? "Onay Bekliyor" : Status == 1 ? "Onaylandı" : Status == 2 ? "Tamamlandı" : "";
        }
    }
}
