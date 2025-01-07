using SalesWebMcv.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMcv.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
}
