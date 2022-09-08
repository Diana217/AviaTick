using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AviaTick
{
    public partial class Passenger
    {
        public Passenger()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "The field mustn`t be empty")]
        public string Name { get; set; } = null!;

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
