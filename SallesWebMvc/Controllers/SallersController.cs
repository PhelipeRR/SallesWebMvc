using Microsoft.AspNetCore.Mvc;
using SallesWebMvc.Models;
using SallesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Controllers
{
    public class SallersController : Controller
    {
        private readonly SellerService _sellerService;
        public SallersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Saller sallers)
        {
            _sellerService.Insert(sallers);
            return RedirectToAction(nameof(Index));
        }
    }
}
