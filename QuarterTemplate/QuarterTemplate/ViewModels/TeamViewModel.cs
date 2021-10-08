using QuarterTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.ViewModels
{
    public class TeamViewModel
    {
        public List<Team> Teams { get; set; }
        public Setting Settings { get; set; }
    }
}
