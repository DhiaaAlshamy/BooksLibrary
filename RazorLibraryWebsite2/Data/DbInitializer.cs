using RazorLibraryWebsite2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorLibraryWebsite2.Data
{
  
        public static class DbInitializer
        {
            public static void Initialize(RazorLibraryWebsite2Context context)
            {
                // Look for any students.
                if (context.Books.Any())
                {
                    return;   // DB has been seeded
                }

               
                var authors = new Author[]
                {
                new Author{Name="someAuthor1",Email="email.com",Gender="male",Mobile=99900,Address="some address",PictureUrl="https://images.unsplash.com/flagged/photo-1570612861542-284f4c12e75f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"},
                new Author{Name="someAuthor2",Email="email.com",Gender="male",Mobile=99900,Address="some address",PictureUrl="https://images.unsplash.com/photo-1438761681033-6461ffad8d80?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"},
                new Author{Name="someAuthor3",Email="email.com",Gender="male",Mobile=99900,Address="some address",PictureUrl="https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80"},
                new Author{Name="someAuthor4",Email="email.com",Gender="male",Mobile=99900,Address="some address",PictureUrl="https://images.unsplash.com/photo-1527980965255-d3b416303d12?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=580&q=80"},
                new Author{Name="someAuthor5",Email="email.com",Gender="male",Mobile=99900,Address="some address",PictureUrl="https://images.unsplash.com/photo-1507591064344-4c6ce005b128?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"},
                new Author{Name="someAuthor6",Email="email.com",Gender="male",Mobile=99900,Address="some address",PictureUrl="https://images.unsplash.com/photo-1531427186611-ecfd6d936c79?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80"},
               
                };

                context.Authors.AddRange(authors);
                context.SaveChanges();

                var publishers = new Publisher[]
                {
                new Publisher{PublisherID=1,Name="some publisher",WebsiteUrl="url",Address="some address"},
            
                };

                context.Publishers.AddRange(publishers);
                context.SaveChanges();
            var students = new Book[]
               {
                new Book{Title="Carson",PublishDate=DateTime.Parse("2019-09-01"),AuthourID=1,PublisherID=1,CoverUrl="https://images.unsplash.com/photo-1592496431122-2349e0fbc666?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1212&q=80",Edition=1},
                new Book{Title="Carson2",PublishDate=DateTime.Parse("2019-09-01"),AuthourID=2,PublisherID=1,CoverUrl="https://images.unsplash.com/photo-1621351183012-e2f9972dd9bf?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=435&q=80",Edition=1},
                new Book{Title="Carson3",PublishDate=DateTime.Parse("2019-09-01"),AuthourID=1,PublisherID=1,CoverUrl="https://images.unsplash.com/photo-1589829085413-56de8ae18c73?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1212&q=80",Edition=1},
                new Book{Title="Carson4",PublishDate=DateTime.Parse("2019-09-01"),AuthourID=2,PublisherID=1,CoverUrl="https://images.unsplash.com/photo-1592496431122-2349e0fbc666?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1824&q=80",Edition=1},
                new Book{Title="Carson5",PublishDate=DateTime.Parse("2019-09-01"),AuthourID=3,PublisherID=1,CoverUrl="https://images.unsplash.com/photo-1544947950-fa07a98d237f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80",Edition=1},

               };

            context.Books.AddRange(students);
            context.SaveChanges();

        }
    }
    }


