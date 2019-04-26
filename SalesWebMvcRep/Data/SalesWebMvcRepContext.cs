using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcRep.Controllers;

namespace SalesWebMvcRep.Models
{
    public class SalesWebMvcRepContext : DbContext
    {
        public SalesWebMvcRepContext (DbContextOptions<SalesWebMvcRepContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Saller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
