using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuarterTemplate.Models;
using QuarterTemplate.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            ProductViewModel productVM = new ProductViewModel
            {
                Products = _context.Products.Include(x => x.ProductImages).Include(x=>x.City)
                          .Include(x=>x.Team).Include(x => x.Status).ToList(),

                Categories = _context.Categories.Include(x=>x.Products).ToList(),
                Amenities = _context.Amenities.Include(x=>x.ProductAmenities).ToList(),
                Statuses = _context.Statuses.Include(x=>x.Products).ToList()

            };

            return View(productVM);
        }
    }
}
