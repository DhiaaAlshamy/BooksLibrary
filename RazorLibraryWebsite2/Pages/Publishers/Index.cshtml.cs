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
    public class IndexModel : PageModel
    {
        private readonly RazorLibraryWebsite2.Data.RazorLibraryWebsite2Context _context;

        public IndexModel(RazorLibraryWebsite2.Data.RazorLibraryWebsite2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publishers.ToListAsync();
        }
    }
}
