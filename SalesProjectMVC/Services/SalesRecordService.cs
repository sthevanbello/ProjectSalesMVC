using Microsoft.EntityFrameworkCore;
using SalesProjectMVC.Data;
using SalesProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProjectMVC.Services
{
    public class SalesRecordService
    {
        private readonly SalesProjectMVCContext _context;

        public SalesRecordService(SalesProjectMVCContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
            {
                result = result.Where(d => d.Date >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                result = result.Where(d => d.Date <= maxDate.Value);
            }

            return await result.Include(x => x.Seller).Include(x => x.Seller.Department).OrderByDescending(x => x.Date).ToListAsync();
        }
    }
}
