using System;
using System.Collections.Generic;

namespace AviaTick
{
    public partial class Airport
    {
        public Airport()
        {
            FlightArrivals = new HashSet<Flight>();
            FlightDepartures = new HashSet<Flight>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CityId { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual ICollection<Flight> FlightArrivals { get; set; }
        public virtual ICollection<Flight> FlightDepartures { get; set; }
    }
}
