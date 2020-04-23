using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Models;                                                                                                      
                
namespace Site.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public string FIO { get; set; }

        public string Email { get; set; }


        public int BookId { get; set; }
        public Book Book{ get; set; }

    }
}
