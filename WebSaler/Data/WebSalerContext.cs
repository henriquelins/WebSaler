using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSaler.Models;

namespace WebSaler.Data
{
    public class WebSalerContext : DbContext
    {
        public WebSalerContext (DbContextOptions<WebSalerContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    
    }
}
