using Microsoft.AspNetCore.Mvc;
using QuarterTemplate.Models;
using QuarterTemplate.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            TeamViewModel teamVM = new TeamViewModel
            {
                Teams = _context.Teams.ToList(),
                Settings = _context.Settings.FirstOrDefault()
            };

            return View(teamVM);
        }
    }
}
