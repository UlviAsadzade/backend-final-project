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

        public IActionResult Detail(int id)
        {
            Product product = _context.Products.Include(x=>x.ProductImages).Include(x => x.Team).Include(x=>x.City)
                .Include(x => x.Category).Include(x => x.ProductAmenities).ThenInclude(x=>x.Amenity)
                .Include(x=>x.Status).FirstOrDefault(x => x.Id == id);

            ViewBag.SocialMedias = _context.Settings.ToList();

            return View(product);
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
    }
}
