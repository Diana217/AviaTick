using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AviaTick
{
    public partial class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field mustn`t be empty")]
        [Display(Name="Date")]
        public DateTime BookDate { get; set; }

        [Required(ErrorMessage = "The field mustn`t be empty")]
        [Display(Name="Seat number")]
        public int SeatNumber { get; set; }

        [Display(Name="Passenger")]
        public int PassengerId { get; set; }

        [Display(Name = "Flight")]
        public int FlightId { get; set; }

        public virtual Flight Flight { get; set; } = null!;
        public virtual Passenger Passenger { get; set; } = null!;
    }
}
