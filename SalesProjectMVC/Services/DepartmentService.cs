using SalesProjectMVC.Data;
using SalesProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProjectMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesProjectMVCContext _context;

        public DepartmentService(SalesProjectMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
