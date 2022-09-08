using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AviaTick
{
    public partial class Aircraft
    {
        public Aircraft()
        {
            Flights = new HashSet<Flight>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "The field mustn`t be empty")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "The field mustn`t be empty")]
        [Display(Name="Number of seats")]
        public int SeatsNumber { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}
