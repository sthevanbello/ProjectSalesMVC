using SalesProjectMVC.Data;
using SalesProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProjectMVC.Services
{
    public class SellerServices
    {
        private readonly SalesProjectMVCContext _context;

        public SellerServices(SalesProjectMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
