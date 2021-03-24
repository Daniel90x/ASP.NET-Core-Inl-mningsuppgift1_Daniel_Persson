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
    public class EventsModel : PageModel
    {
        private readonly ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data.EventContext _context;

        public EventsModel(ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data.EventContext context)
        {
            _context = context;
        }

        public List<Event> Event { get; set; } // Bytat till List

        public async Task<IActionResult> OnGetAsync()
        {
            Event = await _context.Event.ToListAsync();

            return Page();
        }
    }
}
