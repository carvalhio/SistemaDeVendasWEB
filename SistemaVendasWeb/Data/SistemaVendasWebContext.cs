using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaVendasWeb.Models
{
    public class SistemaVendasWebContext : DbContext
    {
        public SistemaVendasWebContext (DbContextOptions<SistemaVendasWebContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaVendasWeb.Models.Department> Department { get; set; }
    }
}
