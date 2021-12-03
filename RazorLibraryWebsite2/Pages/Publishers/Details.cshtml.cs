using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorLibraryWebsite2.Data;
using RazorLibraryWebsite2.Models;

namespace RazorLibraryWebsite2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly RazorLibraryWebsite2.Data.RazorLibraryWebsite2Context _context;

        public DetailsModel(RazorLibraryWebsite2.Data.RazorLibraryWebsite2Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publishers.FirstOrDefaultAsync(m => m.PublisherID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
