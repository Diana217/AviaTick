using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "The field mustn`t be empty")]
        public string Name { get; set; } = null!;

        [Display(Name="City")]
        public int CityId { get; set; }
        [Display(Name = "City")]
        public virtual City City { get; set; } = null!;
        public virtual ICollection<Flight> FlightArrivals { get; set; }
        public virtual ICollection<Flight> FlightDepartures { get; set; }
    }
}
