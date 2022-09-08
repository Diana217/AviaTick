using System;
using System.Collections.Generic;

namespace AviaTick
{
    public partial class Passenger
    {
        public Passenger()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
