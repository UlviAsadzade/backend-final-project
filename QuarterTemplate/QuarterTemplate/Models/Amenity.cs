using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Models
{
    public class Amenity
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 100)]
        public string Name { get; set; }

        [StringLength(maximumLength: 100)]
        public string Icon { get; set; }

        public List<ProductAmenity> ProductAmenities { get; set; }
    }
}
