using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuarterTemplate.Helpers;
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

    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index(int page = 1, string search = null, int? categoryId = null)
        {
            var query = _context.Products.Include(x=>x.Team).AsQueryable();

            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.CurrentSearch = search;
            ViewBag.CurrentCategoryId = categoryId;

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(x => x.Name.Contains(search) || x.Team.FullName.Contains(search));

            if (categoryId != null)
                query = query.Where(x => x.CategoryId == categoryId);


            var pagenatedBooks = PagenatedList<Product>.Create(query.Include(x => x.Category).Include(x => x.ProductImages), 4, page);

            return View(pagenatedBooks);

        }

        public IActionResult Create()
        {
            ViewBag.Teams = _context.Teams.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Cities = _context.Cities.ToList();
            ViewBag.Amenities = _context.Amenities.ToList();
            ViewBag.Statuses = _context.Statuses.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            ViewBag.Teams = _context.Teams.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Cities = _context.Cities.ToList();
            ViewBag.Amenities = _context.Amenities.ToList();
            ViewBag.Statuses = _context.Statuses.ToList();

            if (!_context.Teams.Any(x => x.Id == product.TeamId)) ModelState.AddModelError("TeamId", "Team not found!");
            if (!_context.Categories.Any(x => x.Id == product.CategoryId)) ModelState.AddModelError("CategoryId", "Category not found!");
            if (!_context.Cities.Any(x => x.Id == product.CityId)) ModelState.AddModelError("CityId", "City not found!");
            if (!_context.Statuses.Any(x => x.Id == product.StatusId)) ModelState.AddModelError("StatusId", "Status not found!");

            foreach (var amenityId in product.AmenityIds)
            {
                Amenity amenity = _context.Amenities.FirstOrDefault(x => x.Id == amenityId);

                if (amenity == null)
                {
                    ModelState.AddModelError("AmenityId", "Amenity not found!");
                    return View();
                }

                ProductAmenity productAmenity = new ProductAmenity
                {
                    AmenityId = amenityId
                };

                product.ProductAmenities.Add(productAmenity);
            }


            if (!ModelState.IsValid) return View();

            product.ProductImages = new List<ProductImage>();

            if (product.PosterFile == null)
            {
                ModelState.AddModelError("PosterFile", "Poster file is required");
            }
            else
            {
                if (product.PosterFile.ContentType != "image/png" && product.PosterFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("PosterFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (product.PosterFile.Length > 2097152)
                {
                    ModelState.AddModelError("PosterFile", "File size can not be more than 2MB!");
                    return View();
                }

                string newPosterName = FileManager.Save(_env.WebRootPath, "uploads/product", product.PosterFile);

                ProductImage poster = new ProductImage
                {
                    Image = newPosterName,
                    IsPoster = true,
                };
                product.ProductImages.Add(poster);
            }



            if (product.ImageFiles != null)
            {
                foreach (var file in product.ImageFiles)
                {
                    if (file.ContentType != "image/png" && file.ContentType != "image/jpeg")
                    {
                        continue;
                    }

                    if (file.Length > 2097152)
                    {
                        continue;
                    }

                    string newFileName = FileManager.Save(_env.WebRootPath, "uploads/product", file);

                    ProductImage image = new ProductImage
                    {
                        IsPoster = false,
                        Image = newFileName
                    };

                    product.ProductImages.Add(image);
                }
            }


            if (product.Rooms < 0)
            {
                ModelState.AddModelError("Rooms", "Rooms Count can not be less than 0");
                return View();
            }

            if (product.Bedrooms < 0)
            {
                ModelState.AddModelError("Bedrooms", "Bedrooms count can not be less than 0");
                return View();
            }

            if (product.Bathrooms < 0)
            {
                ModelState.AddModelError("Bathrooms", "Bathrooms count can not be less than 0");
                return View();
            }

            if (product.Rate < 0)
            {
                ModelState.AddModelError("Rate", "Rate count can not be less than 0");
                return View();
            }

            if (product.CostPrice < 0)
            {
                ModelState.AddModelError("CostPrice", "CostPrice count can not be less than 0");
                return View();
            }

            if (product.SalePrice < 0)
            {
                ModelState.AddModelError("SalePrice", "SalePrice count can not be less than 0");
                return View();
            }

            if (product.HomeArea < 0)
            {
                ModelState.AddModelError("HomeArea", "HomeArea count can not be less than 0");
                return View();
            }

            if (product.HouseFloor < 0)
            {
                ModelState.AddModelError("HouseFloor", "HouseFloor count can not be less than 0");
                return View();
            }

            if (product.WhichFloor < 0)
            {
                ModelState.AddModelError("WhichFloor", "WhichFloor count can not be less than 0");
                return View();
            }

            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("index");
        }


        public IActionResult Edit(int id)
        {
            Product product = _context.Products.Include(x => x.ProductImages).Include(x => x.ProductAmenities).FirstOrDefault(x => x.Id == id);

            if (product == null) return RedirectToAction("index", "error", new {area="" });

            ViewBag.Teams = _context.Teams.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Cities = _context.Cities.ToList();
            ViewBag.Amenities = _context.Amenities.ToList();
            ViewBag.Statuses = _context.Statuses.ToList();


            product.AmenityIds = product.ProductAmenities.Select(x => x.AmenityId).ToList();


            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {

            if (!_context.Teams.Any(x => x.Id == product.TeamId)) ModelState.AddModelError("TeamId", "Team not found!");
            if (!_context.Categories.Any(x => x.Id == product.CategoryId)) ModelState.AddModelError("CategoryId", "Category not found!");
            if (!_context.Cities.Any(x => x.Id == product.CityId)) ModelState.AddModelError("CityId", "City not found!");
            if (!_context.Statuses.Any(x => x.Id == product.StatusId)) ModelState.AddModelError("StatusId", "Status not found!");


            if (!ModelState.IsValid) return View();

            Product existProduct = _context.Products.Include(x => x.ProductImages).Include(x => x.ProductAmenities).FirstOrDefault(x => x.Id == product.Id);

            if (existProduct == null) return RedirectToAction("index", "error", new {area="" });


            existProduct.ProductAmenities.RemoveAll((x => !product.AmenityIds.Contains(x.AmenityId)));

            if (product.AmenityIds != null)
            {
                foreach (var amenityId in product.AmenityIds.Where(x => !existProduct.ProductAmenities.Any(pa => pa.AmenityId == x)))
                {
                    ProductAmenity productAmenity = new ProductAmenity
                    {
                        AmenityId = amenityId,
                        ProductId = product.Id
                    };

                    existProduct.ProductAmenities.Add(productAmenity);
                }
            }

            if (product.PosterFile != null)
            {
                if (product.PosterFile.ContentType != "image/png" && product.PosterFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("PosterFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (product.PosterFile.Length > 2097152)
                {
                    ModelState.AddModelError("PosterFile", "File size can not be more than 2MB!");
                    return View();
                }

                ProductImage poster = existProduct.ProductImages.FirstOrDefault(x => x.IsPoster == true);

                string newPosterName = FileManager.Save(_env.WebRootPath, "uploads/product", product.PosterFile);

                if (poster == null)
                {
                    poster = new ProductImage
                    {
                        IsPoster = true,
                        Image = newPosterName,
                        ProductId = product.Id
                    };

                    _context.ProductImages.Add(poster);
                }
                else
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/product", poster.Image);
                    poster.Image = newPosterName;
                }
            }



            List<ProductImage> removablePhotos = existProduct.ProductImages.Where(x => x.IsPoster == false && !product.ProductImageIds.Contains(x.Id)).ToList();

            foreach (var item in removablePhotos)
            {
                FileManager.Delete(_env.WebRootPath, "uploads/product", item.Image);
            }

            existProduct.ProductImages.RemoveAll(x => x.IsPoster == false && !product.ProductImageIds.Contains(x.Id));

            if (product.ImageFiles != null)
            {
                foreach (var file in product.ImageFiles)
                {
                    if (file.ContentType != "image/png" && file.ContentType != "image/jpeg")
                    {
                        continue;
                    }

                    if (file.Length > 2097152)
                    {
                        continue;
                    }

                    string newFileName = FileManager.Save(_env.WebRootPath, "uploads/product", file);

                    ProductImage image = new ProductImage
                    {
                        IsPoster = false,
                        Image = newFileName
                    };

                    existProduct.ProductImages.Add(image);
                }
            }

            if (product.Rooms < 0)
            {
                return RedirectToAction("index","error", new { area=""});
            }

            if (product.Bedrooms < 0)
            {
                return RedirectToAction("index","error", new { area=""});

            }

            if (product.Bathrooms < 0)
            {
                return RedirectToAction("index","error", new { area=""});

            }

            if (product.Rate < 0)
            {
                return RedirectToAction("index","error", new { area=""});

            }

            if (product.CostPrice < 0)
            {
                return RedirectToAction("index","error", new { area=""});

            }

            if (product.SalePrice < 0)
            {
                return RedirectToAction("index","error", new { area=""});

            }

            if (product.HomeArea < 0)
            {
                return RedirectToAction("index","error", new { area=""});

            }

            if (product.HouseFloor < 0)
            {
                return RedirectToAction("index","error", new { area=""});

            }

            if (product.WhichFloor < 0)
            {
                return RedirectToAction("index","error", new { area=""});

            }

            existProduct.Name = product.Name;
            existProduct.TeamId = product.TeamId;
            existProduct.CategoryId = product.CategoryId;
            existProduct.SalePrice = product.SalePrice;
            existProduct.CostPrice = product.CostPrice;
            existProduct.IsFeatured = product.IsFeatured;
            existProduct.Rate = product.Rate;
            existProduct.Desc = product.Desc;
            existProduct.HomeArea = product.HomeArea;
            existProduct.Rooms = product.Rooms;
            existProduct.Bathrooms = product.Bathrooms;
            existProduct.Bedrooms = product.Bedrooms;
            existProduct.CreatedAt = product.CreatedAt;
            existProduct.WhichFloor = product.WhichFloor;
            existProduct.HouseFloor = product.HouseFloor;
            existProduct.Location = product.Location;
            existProduct.ParkingCount = product.ParkingCount;

            _context.SaveChanges();
            return RedirectToAction("index");
        }



        public IActionResult DeleteFetch(int id)
        {
            Product product = _context.Products.FirstOrDefault(x => x.Id == id);

            if (product == null) return Json(new { status = 404 });

            try
            {
                _context.Products.Remove(product);
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
