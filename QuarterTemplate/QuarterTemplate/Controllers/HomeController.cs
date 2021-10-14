using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuarterTemplate.Models;
using QuarterTemplate.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _context.Sliders.OrderBy(x => x.Order).ToList(),
                Abouts = _context.Abouts.ToList(),
                Services = _context.Services.OrderBy(x => x.Order).Take(3).ToList(),
                Amenities = _context.Amenities.ToList(),
                Settings=_context.Settings.FirstOrDefault(),
                Cities=_context.Cities.ToList(),
                Categories=_context.Categories.ToList(),
                Statuses=_context.Statuses.ToList(),
                LastSellProduct = _context.Orders.Include(x=>x.Product).ThenInclude(y=>y.ProductImages).Take(3).OrderByDescending(x=>x.Id).FirstOrDefault().Product,
                FeaturedProducts = _context.Products.Include(x => x.ProductImages).
                 Include(x => x.Status).Include(x => x.City).Include(x => x.Team).
                 Where(x => x.IsFeatured).ToList()
            };
            return View(homeVM);
        }

        public IActionResult GetProduct(int id)
        {
            Product product = _context.Products
                .Include(x => x.ProductImages).Include(x => x.Category)
                .Include(x => x.ProductAmenities).ThenInclude(x => x.Amenity)
                .FirstOrDefault(x => x.Id == id);

            return PartialView("_ProductModalPartial", product);
        }


    }
}
