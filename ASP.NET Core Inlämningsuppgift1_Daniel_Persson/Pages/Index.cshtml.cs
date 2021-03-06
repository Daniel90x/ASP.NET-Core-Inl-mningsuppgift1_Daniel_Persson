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
    public class IndexModel : PageModel
    {
        private readonly ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data.EventContext _context;

        public IndexModel(ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data.EventContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Event.ToListAsync(); // bytade Event efter _context. till Events...
        }
    }
}
