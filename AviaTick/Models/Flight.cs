﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AviaTick
{
    public partial class Flight
    {
        public Flight()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }

        [Display(Name ="Departure time")]
        [Required(ErrorMessage = "The field mustn`t be empty")]
        public TimeSpan DepartureTime { get; set; }

        [Display(Name = "Arrival time")]
        [Required(ErrorMessage = "The field mustn`t be empty")]
        public TimeSpan ArrivalTime { get; set; }

        [Display(Name = "Departure airport")]
        public int DepartureId { get; set; }

        [Display(Name = "Arrival airport")]
        public int ArrivalId { get; set; }

        [Display(Name = "Aircraft")]
        public int AircraftId { get; set; }

        public virtual Aircraft Aircraft { get; set; } = null!;
        public virtual Airport Arrival { get; set; } = null!;
        public virtual Airport Departure { get; set; } = null!;
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
