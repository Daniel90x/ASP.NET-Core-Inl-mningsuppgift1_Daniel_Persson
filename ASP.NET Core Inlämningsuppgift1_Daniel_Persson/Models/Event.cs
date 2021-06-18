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
        
        public string Adress { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public int Spots_available { get; set; } // ny
        public List<Attendee> Attendees { get; set; }
        
        public Organizer Organizers { get; set; } 

    }
}

