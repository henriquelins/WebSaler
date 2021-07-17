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

        public DbSet<WebSaler.Models.Department> Department { get; set; }
    }
}
