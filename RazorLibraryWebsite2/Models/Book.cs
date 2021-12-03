using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorLibraryWebsite2.Models
{
    public class Book
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public int AuthourID { get; set; }
        public int PublisherID { get; set; }
        public Author Authour { get; set; }
        public Publisher Publisher { get; set; }
        public DateTime PublishDate { get; set; }
        public int Edition { get; set; }
        public string CoverUrl { get; set; }

        }
    }

