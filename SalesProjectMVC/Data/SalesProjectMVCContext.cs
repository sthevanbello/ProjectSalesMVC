using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesProjectMVC.Models;

namespace SalesProjectMVC.Data
{
    public class SalesProjectMVCContext : DbContext
    {
        public SalesProjectMVCContext (DbContextOptions<SalesProjectMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesProjectMVC.Models.Department> Department { get; set; }
    }
}
