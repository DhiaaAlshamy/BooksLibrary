using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RazorLibraryWebsite2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorLibraryWebsite2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly RazorLibraryWebsite2.Data.RazorLibraryWebsite2Context _context;

        public IList<Book> Book { get; set; }
        public IList<Author> Author { get; set; }

        public IndexModel(ILogger<IndexModel> logger,RazorLibraryWebsite2.Data.RazorLibraryWebsite2Context context)
        {
            _logger = logger;
                        _context = context;

        }
        //public IndexModel(RazorLibraryWebsite2.Data.RazorLibraryWebsite2Context context)
        //{
        //    _context = context;
        //}

        public async Task OnGetAsync()
        {
            Book = await _context.Books.ToListAsync() ;
            Author = await _context.Authors.ToListAsync() ;
        }
    }
}
