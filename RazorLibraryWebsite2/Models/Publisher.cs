using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorLibraryWebsite2.Models
{
    public class Publisher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublisherID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WebsiteUrl { get; set; }
        public ICollection<Book> Books { get; set; }


    }
}
