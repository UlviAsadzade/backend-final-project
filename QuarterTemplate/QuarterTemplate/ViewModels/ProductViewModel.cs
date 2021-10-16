using QuarterTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.ViewModels
{
    public class ProductViewModel
    {
        public PagenatedList<Product> Products { get; set; }

        public List<Category> Categories { get; set; }

        public List<Amenity> Amenities { get; set; }

        public List<Status> Statuses { get; set; }



    }
}
