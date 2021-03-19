using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public int OrganizerId { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public List<Attendee> Attendees { get; set; }



    }
}

// du kan lägga till de två andra klasserna direkt till contexten
// som SetDb<MyModel> properites