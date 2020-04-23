using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Models;

namespace Site
{
    public class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Name = "Epidemia",
                        Author = "Kto-to",
                        DateIn = DateTime.Now,
                        Info = "choto",
                        isHave = true,
                        Link = "hello"
                    },
                   new Book
                   {
                       Name = "Epidemia",
                       Author = "Kto-to",
                       DateIn = DateTime.Now,
                       Info = "choto",
                       isHave = true,
                       Link = "hello"
                   },
                   new Book
                   {
                       Name = "Epidemia",
                       Author = "Kto-to",
                       DateIn = DateTime.Now,
                       Info = "choto",
                       isHave = true,
                       Link = "hello"
                   });
                context.SaveChanges();
            }

            if (!context.Readers.Any())
            {
                context.Readers.AddRange(
                    new Reader
                    {
                        FIO = "alfred",
                        Email = "ahsdhashd"
                    },
                     new Reader
                     {
                         FIO = "alfred",
                         Email = "ahsdhashd"
                     },
                     new Reader
                     {
                         FIO = "alfred",
                         Email = "ahsdhashd"
                     });
                context.SaveChanges();
            }

        }
    }


}
