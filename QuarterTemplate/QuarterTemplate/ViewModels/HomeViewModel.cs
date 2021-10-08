using QuarterTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<About> Abouts { get; set; }
        public List<Service> Services { get; set; }
        public List<Amenity> Amenities { get; set; }
        public Setting Settings { get; set; }

    }
}
