using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AviaTick
{
    public partial class City
    {
        public City()
        {
            Airports = new HashSet<Airport>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "The field mustn`t be empty")]
        public string Name { get; set; } = null!;

        public byte[]? Photo { get; set; }

        public virtual ICollection<Airport> Airports { get; set; }
    }
}
