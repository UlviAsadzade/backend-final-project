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
        public List<Status> Statuses { get; set; }
        public List<City> Cities { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> FeaturedProducts { get; set; }
        public Product LastAddedProduct { get; set; }
        public List<Review> Reviews { get; set; }



    }
}
