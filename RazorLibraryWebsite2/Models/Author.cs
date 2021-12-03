using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorLibraryWebsite2.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string  Email { get; set; }
        public string Gender { get; set; }
        public int Mobile { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PictureUrl { get; set; }
        public ICollection<Book> Books { get; set; }
        
    }
}
