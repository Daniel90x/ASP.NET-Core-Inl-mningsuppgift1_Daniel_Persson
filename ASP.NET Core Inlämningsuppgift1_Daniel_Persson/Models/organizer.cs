using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Models; // maybe
using ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data;

namespace ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Models
{
    public class organizer
    {
        public int OrganizerId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Event> Events { get; set; }
    }
}
