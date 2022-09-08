using System;
using System.Collections.Generic;

namespace AviaTick
{
    public partial class Flight
    {
        public Flight()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public int DepartureId { get; set; }
        public int ArrivalId { get; set; }
        public int AircraftId { get; set; }

        public virtual Aircraft Aircraft { get; set; } = null!;
        public virtual Airport Arrival { get; set; } = null!;
        public virtual Airport Departure { get; set; } = null!;
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
