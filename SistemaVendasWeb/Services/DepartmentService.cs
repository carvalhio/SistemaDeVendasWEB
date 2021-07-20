using SistemaVendasWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaVendasWeb.Services
{
    public class DepartmentService
    {
        private readonly SistemaVendasWebContext _context;

        public DepartmentService(SistemaVendasWebContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {

            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
