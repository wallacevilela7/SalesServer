using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesServerMvc.Models;

namespace SalesServerMvc.Data
{
    public class SalesServerMvcContext : DbContext
    {
        public SalesServerMvcContext(DbContextOptions<SalesServerMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
