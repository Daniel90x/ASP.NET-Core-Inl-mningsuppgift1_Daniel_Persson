using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data;
using ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Models;

namespace ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Pages
{

    public class MyEventsModel : PageModel
    {



        private readonly ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data.EventContext _context;


        public MyEventsModel(ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data.EventContext context)
        {
            _context = context;
        }

        // [BindProperty]

        public IList<Event> Event { get; set; } // La till I före List här med



        public async Task OnGetAsync() // Behövs en bättre funktion här som låter oss adda events till Attendee
        {
            var attendee = await _context.Attendees.Include(a => a.Events).FirstOrDefaultAsync(); // NYTT


            Event = attendee.Events; // NYTT



            //////////////////////////
            ///Gammal kod
            // Event = await _context.Event.ToListAsync();

            // return Page();
        }
    }
    
}
