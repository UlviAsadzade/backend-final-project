using QuarterTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Areas.Manage.ViewModels
{
    public class DashboardViewModel
    {
        public List<Order> Orders { get; set; }

        public double SoldProductPercent { get; set; }



    }
}
