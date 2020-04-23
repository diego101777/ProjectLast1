using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Site.Models;

namespace Site.Models
{
    public class CommentsContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }


        public CommentsContext(DbContextOptions<CommentsContext> options)
           : base(options)
        {
        }

    }
}
