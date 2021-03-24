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
    public class DetailsModel : PageModel
    {
        private readonly ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data.EventContext _context;

        public DetailsModel(ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data.EventContext context)
        {
            _context = context;
        }

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
    }
}
