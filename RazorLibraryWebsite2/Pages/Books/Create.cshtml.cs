using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorLibraryWebsite2.Data;
using RazorLibraryWebsite2.Models;

namespace RazorLibraryWebsite2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly RazorLibraryWebsite2.Data.RazorLibraryWebsite2Context _context;

        public CreateModel(RazorLibraryWebsite2.Data.RazorLibraryWebsite2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AuthourID"] = new SelectList(_context.Authors, "AuthorID", "Name");
        ViewData["PublisherID"] = new SelectList(_context.Publishers, "PublisherID", "Name");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Books.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
