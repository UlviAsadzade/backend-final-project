using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuarterTemplate.Areas.Manage.ViewModels;
using QuarterTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Areas.Manage.Controllers
{
    [Area("manage")]

    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            //AppUser admin = new AppUser
            //{
            //    UserName = "SuperAdmin",
            //    FullName = "Super Admin"
            //};

            //var result = await _userManager.CreateAsync(admin, "Admin123");

            //IdentityRole role1 = new IdentityRole("SuperAdmin");
            //await _roleManager.CreateAsync(role1);
            //IdentityRole role2 = new IdentityRole("Admin");
            //await _roleManager.CreateAsync(role2);
            //IdentityRole role3 = new IdentityRole("Member");
            //var result = await _roleManager.CreateAsync(role3);

            //AppUser appUser = await _userManager.FindByNameAsync("SuperAdmin");
            //await _userManager.AddToRoleAsync(appUser, "SuperAdmin");

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser admin = _userManager.Users.FirstOrDefault(x => x.UserName == loginVM.UserName && x.IsAdmin == true);

            if (admin == null)
            {
                ModelState.AddModelError("", "istifadeci adi ve ya sifre yanlisdir!");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(admin, loginVM.Password, loginVM.IsPersistent, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "istifadeci adi ve ya sifre yanlisdir!");
                return View();
            }

            return RedirectToAction("index", "dashboard");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("login", "account");
        }


        [Authorize(Roles = "SuperAdmin")]
        public IActionResult AddAdmin()
        {
            return View();
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpPost]
        public async Task<IActionResult> AddAdmin(AdminViewModel adminVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser admin = await _userManager.FindByNameAsync(adminVM.UserName);

            if (admin != null)
            {
                ModelState.AddModelError("UserName", "UserName already taken!");
                return View();
            }

            admin = await _userManager.FindByEmailAsync(adminVM.Email);
            if (admin != null)
            {
                ModelState.AddModelError("Email", "Email already taken!");
                return View();
            }


            admin = new AppUser
            {
                FullName = adminVM.FullName,
                UserName = adminVM.UserName,
                Email = adminVM.Email,
                IsAdmin = true
            };

            var result = await _userManager.CreateAsync(admin, adminVM.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View();
            }

            await _userManager.AddToRoleAsync(admin, "Admin");
            await _signInManager.SignInAsync(admin, true);

            return RedirectToAction("index", "dashboard");
        }
    }
}
