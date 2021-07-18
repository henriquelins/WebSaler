using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSaler.Data;
using WebSaler.Models;
using Microsoft.EntityFrameworkCore;

namespace WebSaler.Services
{
    public class DepartmentService
    {
        private readonly WebSalerContext _context;

        public DepartmentService(WebSalerContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
