using System.Linq;
using VendasMVC.Models;
using System.Collections.Generic;

namespace VendasMVC.Services
{
    public class DepartmentService
    {
        private readonly VendasMVCContext _context;

        public DepartmentService(VendasMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
