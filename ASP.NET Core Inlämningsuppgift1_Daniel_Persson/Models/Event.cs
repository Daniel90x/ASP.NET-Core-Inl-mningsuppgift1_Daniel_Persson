using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Models; // maaaybe
using ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data;

namespace ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        // public int OrganizerId { get; set; }

        // public int AttendeeId { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public List<Attendee> Attendees { get; set; }
        
        public Organizer Organizers { get; set; } // remove....



    }
}

// du kan lägga till de två andra klasserna direkt till contexten
// som SetDb<MyModel> properites