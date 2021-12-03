using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorLibraryWebsite2.Data;
using RazorLibraryWebsite2.Models;

namespace RazorLibraryWebsite2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly RazorLibraryWebsite2.Data.RazorLibraryWebsite2Context _context;

        public DetailsModel(RazorLibraryWebsite2.Data.RazorLibraryWebsite2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Books
                .Include(b => b.Authour)
                .Include(b => b.Publisher).FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
