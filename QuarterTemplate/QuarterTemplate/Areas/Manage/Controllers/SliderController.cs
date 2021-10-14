using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QuarterTemplate.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "Admin,SuperAdmin")]

    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }

        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Slider slider)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (slider.ImageFile != null)
            {
                if (slider.ImageFile.ContentType != "image/jpeg" && slider.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Content type can be only jpeg or png!");
                    return View();
                }

                if (slider.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size can not be more than 2mb!");
                    return View();
                }

                string filename = slider.ImageFile.FileName;

                if (filename.Length > 64)
                {
                    filename = filename.Substring(filename.Length - 64, 64);
                }
                string newFileName = Guid.NewGuid().ToString() + filename;

                string path = Path.Combine(_env.WebRootPath, "uploads/slider", newFileName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    slider.ImageFile.CopyTo(stream);
                }

                slider.Image = newFileName;
            }

            _context.Sliders.Add(slider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }


        public IActionResult Edit(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (slider == null) return NotFound();

            return View(slider);
        }

        [HttpPost]
        public IActionResult Edit(Slider slider)
        {
            if (!ModelState.IsValid) return View();

            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);

            if (existSlider == null) return NotFound();

            string newFileName = null;
            if (slider.ImageFile != null)
            {
                if (slider.ImageFile.ContentType != "image/png" && slider.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (slider.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size can not be more than 2MB!");
                    return View();
                }

                newFileName = Guid.NewGuid().ToString() + slider.ImageFile.FileName;
                string path = Path.Combine(_env.WebRootPath, "uploads/slider", newFileName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    slider.ImageFile.CopyTo(stream);
                }
            }

            if (newFileName != null || slider.Image == null)
            {
                if (existSlider.Image != null)
                {
                    string deletePath = Path.Combine(_env.WebRootPath, "uploads/slider", existSlider.Image);

                    if (System.IO.File.Exists(deletePath))
                    {
                        System.IO.File.Delete(deletePath);
                    }
                }

                existSlider.Image = newFileName;
            }

            existSlider.Title1 = slider.Title1;
            existSlider.Title2 = slider.Title2;
            existSlider.Subtitle = slider.Subtitle;
            existSlider.UrlText = slider.UrlText;
            existSlider.RedirectUrl = slider.RedirectUrl;
            existSlider.Order = slider.Order;
            existSlider.Icon = slider.Icon;
            existSlider.Desc = slider.Desc;

            _context.SaveChanges();
            return RedirectToAction("index");
        }


        public IActionResult DeleteFetch(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (slider == null) return Json(new { status = 404 });

            try
            {
                _context.Sliders.Remove(slider);
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
