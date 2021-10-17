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

    public class StatusController : Controller
    {
        private readonly AppDbContext _context;

        public StatusController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Status> statuses = _context.Statuses.ToList();

            return View(statuses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Status status)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Statuses.Add(status);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Status status = _context.Statuses.FirstOrDefault(x => x.Id == id);

            if (status == null) return RedirectToAction("index", "error", new {area="" });

            return View(status);
        }

        [HttpPost]
        public IActionResult Edit(Status status)
        {
            Status existStatus = _context.Statuses.FirstOrDefault(x => x.Id == status.Id);

            if (existStatus == null) return RedirectToAction("index", "error", new {area="" });

            existStatus.Name = status.Name;

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult DeleteFetch(int id)
        {
            Status status = _context.Statuses.FirstOrDefault(x => x.Id == id);

            if (status == null) return Json(new { status = 404 });

            try
            {
                _context.Statuses.Remove(status);
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
