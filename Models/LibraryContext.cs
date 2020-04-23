using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Site.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Reader> Readers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options)
           : base(options)
        {
        }

    }
}
