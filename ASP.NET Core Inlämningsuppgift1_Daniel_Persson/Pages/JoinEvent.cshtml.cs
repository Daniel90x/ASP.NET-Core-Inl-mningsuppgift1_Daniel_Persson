using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data;
using ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Models;

namespace ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Pages
{
    public class JoinEventMOdel : PageModel
    {
        private readonly ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data.EventContext _context;

        public JoinEventMOdel(ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data.EventContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Event Event { get; set; }
        

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.


        [BindProperty] // WiP har inte fått det till att fungera än, så att man kan joina.
        public Event AddEvent { get; set; }
        // public Attendee Attendee { get; set; }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            var attendee = await _context.Attendees.Where(a => a.Id == 1).Include(e => e.Events).FirstOrDefaultAsync();

            var join = await _context.Event.Where(e => e.Id == id).FirstOrDefaultAsync();

            attendee.Events.Add(join);
            await _context.SaveChangesAsync();
            return RedirectToPage("/MyEvents");





        }




    }
}

