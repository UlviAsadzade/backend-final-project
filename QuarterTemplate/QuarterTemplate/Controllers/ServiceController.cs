using Microsoft.AspNetCore.Mvc;
using QuarterTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Service> services = _context.Services.Skip(3).Take(6).ToList();

            return View(services);
        }
    }
}
