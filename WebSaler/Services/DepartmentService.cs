using System.Collections.Generic;
using System.Linq;
using WebSaler.Data;
using WebSaler.Models;

namespace WebSaler.Services
{
    public class DepartmentService
    {
        private readonly WebSalerContext _context;

        public DepartmentService(WebSalerContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
