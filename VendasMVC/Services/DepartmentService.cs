using System.Linq;
using VendasMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VendasMVC.Services
{
    public class DepartmentService
    {
        private readonly VendasMVCContext _context;

        public DepartmentService(VendasMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
