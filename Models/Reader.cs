using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Models
{
    public class Reader
    {
        public int ReaderId { get; set; }

        public string FIO { get; set; }

        public string Email { get; set; }
    }
}
