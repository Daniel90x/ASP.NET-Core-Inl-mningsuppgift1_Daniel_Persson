using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Models; // maaybe
using ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data;

namespace ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Models
{
    public class Attendee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // public int EventID { get; set; } // Ny
        // public Event Event { get; set; } // Ny
        public List<Event> Events { get; set; }
    }
}
