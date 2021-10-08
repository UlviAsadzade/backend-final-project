using Microsoft.AspNetCore.Mvc;
using QuarterTemplate.Models;
using QuarterTemplate.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            AboutViewModel aboutVM = new AboutViewModel
            {
                Abouts = _context.Abouts.ToList(),
                Settings=_context.Settings.FirstOrDefault()
            };

            return View(aboutVM);
        }
    }
}
