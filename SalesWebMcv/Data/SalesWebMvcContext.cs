using SalesWebMcv.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMcv.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        // Adicione seus DbSets aqui
        public DbSet<Department> Departments { get; set; }
    }
}
