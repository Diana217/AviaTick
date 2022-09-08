using System;
using System.Collections.Generic;

namespace AviaTick
{
    public partial class Aircraft
    {
        public Aircraft()
        {
            Flights = new HashSet<Flight>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int SeatsNumber { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}
