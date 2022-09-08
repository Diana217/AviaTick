using System;
using System.Collections.Generic;

namespace AviaTick
{
    public partial class City
    {
        public City()
        {
            Airports = new HashSet<Airport>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public byte[]? Photo { get; set; }

        public virtual ICollection<Airport> Airports { get; set; }
    }
}
