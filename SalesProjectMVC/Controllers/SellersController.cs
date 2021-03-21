using Microsoft.AspNetCore.Mvc;
using SalesProjectMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProjectMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerServices _sellerServices;

        public SellersController(SellerServices sellerServices)
        {
            _sellerServices = sellerServices;
        }

        public IActionResult Index()
        {
            var list = _sellerServices.FindAll();

            return View(list);
        }


    }
}
