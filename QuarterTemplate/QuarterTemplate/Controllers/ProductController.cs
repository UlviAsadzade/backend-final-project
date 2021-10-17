using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
        private readonly UserManager<AppUser> _userManager;


        public ProductController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }


        public IActionResult Index(int? minPrice,int? maxPrice, int page = 1, int? categoryId = null, int? amenityId = null, int? statusId = null, int? cityId = null, string search = null)
        {
            var query = _context.Products.Where(x=>x.IsSold==false).Include(x=>x.Team).AsQueryable();
            if (minPrice!=null) query = query.Where(x => x.SalePrice > minPrice);
            if (maxPrice != null) query = query.Where(x => x.SalePrice < maxPrice);

            ViewBag.CurrentCategoryId = categoryId;
            ViewBag.CurrentAmenityId = amenityId;
            ViewBag.CurrentStatusId = statusId;
            ViewBag.CurrentSearch = search;
            ViewBag.CurrentCity = cityId;

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(x => x.Name.Contains(search));

            if (categoryId != null)
                query = query.Where(x => x.CategoryId == categoryId);

            if (amenityId != null)
                query = query.Where(x => x.ProductAmenities.Any(y => y.AmenityId == amenityId));

            if (statusId != null)
                query = query.Where(x => x.StatusId == statusId);

            if (cityId != null)
                query = query.Where(x => x.CityId == cityId);

            var pagenatedBooks = PagenatedList<Product>.Create(query.Include(x => x.Category).Include(x=>x.City).Include(x=>x.Team).Include(x => x.ProductImages), 4, page);

            ProductViewModel productVM = new ProductViewModel
            {
                Products = pagenatedBooks,
                Categories = _context.Categories.Include(x=>x.Products).ToList(),
                Amenities = _context.Amenities.Include(x=>x.ProductAmenities).ToList(),
                Statuses = _context.Statuses.Include(x=>x.Products).ToList()

            };

            return View(productVM);
        }

        public IActionResult Detail(int id)
        {
            if (!ModelState.IsValid) return View();

            Product product = _context.Products.Include(x=>x.ProductImages).Include(x => x.Team).Include(x=>x.City)
                .Include(x => x.Category).Include(x => x.ProductAmenities).ThenInclude(x=>x.Amenity)
                .Include(x=>x.Status).FirstOrDefault(x => x.Id == id);

            List<Review> reviews = _context.Reviews.Include(x => x.AppUser).Where(x => x.IsAccepted && x.ProductId == id).ToList();
            Order order = _context.Orders.Include(x => x.AppUser).FirstOrDefault(x => x.Product.Id == id);


            ViewBag.Settings = _context.Settings.FirstOrDefault();
            ViewBag.SocialMedias = _context.Settings.ToList();
            ViewBag.Categories = _context.Categories.Include(x => x.Products).ToList();
            ViewBag.SameProducts = _context.Products.Where(x=>x.IsSold==false).Include(x => x.ProductImages).Include(x=>x.Team)
                .Include(x => x.City).Include(x => x.Status).ToList();

            ReviewViewModel reviewVm = new ReviewViewModel
            {
                Product = product,
                Reviews = reviews,
                Order = order
            };

            return View(reviewVm);
        }


        [Authorize(Roles = "Member")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Comment(int id, ReviewViewModel model)
        {

            Product product = _context.Products.Find(id);
            if (product == null) return NotFound();

            AppUser member = await _userManager.FindByNameAsync(User.Identity.Name);

            if (model.Text.Length > 250)
            {
                ModelState.AddModelError("Text", "Your text is very length");
                return RedirectToAction("index", "error");
            }

            Review review = new Review
            {
                AppUserId = member.Id,
                ProductId = id,
                Rate = model.Rate,
                Text = model.Text,
                CreatedAt = DateTime.UtcNow
            };


            _context.Reviews.Add(review);

            await _context.SaveChangesAsync();

            return Redirect(HttpContext.Request.Headers["Referer"].ToString());
        }


        public IActionResult AddToWishlist(int id)
        {
            Product product = _context.Products.Include(x => x.ProductImages).FirstOrDefault(x => x.Id == id);
            WishlistItemViewModel wishlistItem = null;

            if (product == null) return NotFound();

            AppUser member = null;

            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);

            }

            List<WishlistItemViewModel> products = new List<WishlistItemViewModel>();

            if (member == null)
            {
                string productStr;

                if (HttpContext.Request.Cookies["Products"] != null)
                {
                    productStr = HttpContext.Request.Cookies["Products"];
                    products = JsonConvert.DeserializeObject<List<WishlistItemViewModel>>(productStr);

                    wishlistItem = products.FirstOrDefault(x => x.ProductId == id);
                }

                if (wishlistItem == null)
                {
                    wishlistItem = new WishlistItemViewModel
                    {
                        ProductId = product.Id,
                        Name = product.Name,
                        Image = product.ProductImages.FirstOrDefault(x => x.IsPoster == true).Image,
                        Price = (product.SalePrice),
                    };
                    products.Add(wishlistItem);
                }
                else
                {
                    products.Remove(wishlistItem);
                }
                productStr = JsonConvert.SerializeObject(products);
                HttpContext.Response.Cookies.Append("Products", productStr);
            }
            else
            {
                WishlistItem memberWishlistItem = _context.WishlistItems.FirstOrDefault(x => x.AppUserId == member.Id && x.ProductId == id);
                if (memberWishlistItem == null)
                {
                    memberWishlistItem = new WishlistItem
                    {
                        AppUserId = member.Id,
                        ProductId = id,
                        
                    };
                    _context.WishlistItems.Add(memberWishlistItem);
                }
                else
                {
                    _context.WishlistItems.Remove(memberWishlistItem);
                }
                _context.SaveChanges();

                products = _context.WishlistItems.Include(x => x.Product).ThenInclude(bi => bi.ProductImages)
                    .Where(x => x.AppUserId == member.Id)
                    .Select(x => new WishlistItemViewModel
                    {
                        ProductId = x.ProductId,
                        Count = x.Count,
                        Name = x.Product.Name,
                        Price = x.Product.SalePrice,
                        Image = x.Product.ProductImages.FirstOrDefault(b => b.IsPoster == true).Image
                    })
                    .ToList();
            }

            return PartialView("_WishlistPartial", products);
        }


        public IActionResult DeleteWishlistItem(int id)
        {
            Product product = _context.Products.Include(x => x.ProductImages).FirstOrDefault(x => x.Id == id);
            WishlistItemViewModel wishlistItem = null;
            if (product == null) return NotFound();

            AppUser member = null;

            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);

            }

            List<WishlistItemViewModel> products = new List<WishlistItemViewModel>();

            if (member == null)
            {

                string productStr = HttpContext.Request.Cookies["Products"];
                products = JsonConvert.DeserializeObject<List<WishlistItemViewModel>>(productStr);

                wishlistItem = products.FirstOrDefault(x => x.ProductId == id);

                products.Remove(wishlistItem);

                productStr = JsonConvert.SerializeObject(products);
                HttpContext.Response.Cookies.Append("Products", productStr);
            }

            else
            {
                WishlistItem memberWishlistItem = _context.WishlistItems.Include(x => x.Product).FirstOrDefault(x => x.AppUserId == member.Id && x.ProductId == id);

                _context.WishlistItems.Remove(memberWishlistItem);

                _context.SaveChanges();

                products = _context.WishlistItems.Include(x => x.Product).ThenInclude(bi => bi.ProductImages).Where(x => x.AppUserId == member.Id)
                    .Select(x => new WishlistItemViewModel { ProductId = x.ProductId, Count = x.Count, Name = x.Product.Name, Price = x.Product.SalePrice , Image = x.Product.ProductImages.FirstOrDefault(b => b.IsPoster == true).Image }).ToList();

            }
            return PartialView("_WishlistPartial", products);
        }


        [Authorize(Roles = "Member")]

        public IActionResult CreateOrder(int id)
        {
            AppUser member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);

            Product product = _context.Products.Include(x=>x.City).FirstOrDefault(x => x.Id == id);

            if (product == null) return NotFound();

            Order order = new Order
            {
                AppUserId = member.Id,
                ProductId = product.Id,
                ProductName = product.Name,
                CostPrice = product.CostPrice,
                SalePrice = product.SalePrice,
                Address = product.City.Name,
                FullName = member.FullName,
                Email = member.Email,
                CreatedAt = DateTime.UtcNow,
                Status = Models.Enums.OrderStatus.Pending

            };

            
            _context.Orders.Add(order);
            _context.SaveChanges();

            return RedirectToAction("profile", "account");
        }
    }
}
