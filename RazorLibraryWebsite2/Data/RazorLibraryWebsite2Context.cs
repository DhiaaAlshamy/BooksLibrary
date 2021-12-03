using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorLibraryWebsite2.Models;

namespace RazorLibraryWebsite2.Data
{
    public class RazorLibraryWebsite2Context : DbContext
    {
        public RazorLibraryWebsite2Context (DbContextOptions<RazorLibraryWebsite2Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Author>().ToTable("Authors");
            modelBuilder.Entity<Publisher>().ToTable("Publishers");
        }
    }
}

