using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuarterTemplate.Models;
using QuarterTemplate.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Areas.Manage.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    [Area("manage")]
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IEmailService _emailService;


        public OrderController(AppDbContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;

        }
        public IActionResult Index()
        {
            List<Order> orders = _context.Orders.OrderByDescending(x=>x.Id).ToList();

            return View(orders);
        }

        public IActionResult Edit(int id)
        {
            Order order = _context.Orders.FirstOrDefault(x => x.Id == id);

            if (order == null) return NotFound();

            return View(order);
        }

        public IActionResult Accept(int id)
        {
            Order order = _context.Orders.Include(x=>x.Product).Include(x => x.AppUser).FirstOrDefault(x => x.Id == id);
            if (order == null) return NotFound();
            
            order.Status = Models.Enums.OrderStatus.Accepted;
            order.Product.IsSold = true;
            _context.SaveChanges();

            string body = string.Empty;
            using (StreamReader reader = new StreamReader("wwwroot/templates/order.html"))
            {
                body = reader.ReadToEnd();
            }

            body = body.Replace("{{price}}", order.SalePrice.ToString());

            string orders = string.Empty;

            orders = @$"<tr><td width=\""75 %\"" align=\""left\"" style =\""font - family: Open Sans, Helvetica, Arial, sans-serif; font - size: 16px; font - weight: 400; line - height: 24px; padding: 15px 10px 5px 10px;\"" > {order.ProductName} </td>
           </tr>";

            body = body.Replace("{{price}}", order.SalePrice.ToString()).Replace("{{order}}", orders);


            _emailService.Send(order.AppUser.Email, "Order accepted", body);

            return RedirectToAction("index");
        }

        public IActionResult Reject(int id)
        {
            Order order = _context.Orders.Include(x=>x.Product).FirstOrDefault(x => x.Id == id);
            if (order == null) return NotFound();

            order.Status = Models.Enums.OrderStatus.Rejected;
            order.Product.IsSold = false;

            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
