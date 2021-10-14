using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuarterTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "Admin,SuperAdmin")]

    public class AmenityController : Controller
    {
        private readonly AppDbContext _context;

        public AmenityController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Amenity> amenities = _context.Amenities.ToList();

            return View(amenities);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Amenity amenity)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Amenities.Add(amenity);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Amenity amenity = _context.Amenities.FirstOrDefault(x => x.Id == id);

            if (amenity == null) return NotFound();

            return View(amenity);
        }

        [HttpPost]
        public IActionResult Edit(Amenity amenity)
        {
            Amenity existAmenity = _context.Amenities.FirstOrDefault(x => x.Id == amenity.Id);

            if (existAmenity == null) return NotFound();

            existAmenity.Name = amenity.Name;
            existAmenity.Icon = amenity.Icon;

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult DeleteFetch(int id)
        {
            Amenity amenity = _context.Amenities.FirstOrDefault(x => x.Id == id);

            if (amenity == null) return Json(new { status = 404 });

            try
            {
                _context.Amenities.Remove(amenity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return Json(new { status = 500 });
            }

            return Json(new { status = 200 });
        }
    }
}
