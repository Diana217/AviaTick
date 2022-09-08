using System;
using System.Collections.Generic;

namespace AviaTick
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public DateTime BookDate { get; set; }
        public int SeatNumber { get; set; }
        public int PassengerId { get; set; }
        public int FlightId { get; set; }

        public virtual Flight Flight { get; set; } = null!;
        public virtual Passenger Passenger { get; set; } = null!;
    }
}
