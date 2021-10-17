using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QuarterTemplate.Areas.Manage.ViewModels;
using QuarterTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "Admin,SuperAdmin")]

    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public DashboardController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            double soldProductCount = _context.Products.Where(x=>x.IsSold==true).Count();

            double totalProductCount = _context.Products.Count();

            DashboardViewModel dashboardVM = new DashboardViewModel
            {
                Orders = _context.Orders.ToList(),
                SoldProductPercent= Math.Ceiling(soldProductCount / totalProductCount * 100)
            };

            return View(dashboardVM);
        }
    }
}
