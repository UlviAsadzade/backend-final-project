using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int TeamId { get; set; }
        public int CityId { get; set; }
        public int StatusId { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Name { get; set; }

        [Required]
        public double CostPrice { get; set; }

        [Required]
        public double SalePrice { get; set; }

        [StringLength(maximumLength: 500)]
        public string Desc { get; set; }

        [Required]
        public bool IsFeatured { get; set; }

        [Required]
        public int Rate { get; set; }

        [Required]
        public double HomeArea { get; set; }

        [Required]
        public int Rooms { get; set; }

        public int Bedrooms { get; set; }

        public int Bathrooms { get; set; }

        public DateTime CreatedAt { get; set; }

        [StringLength(maximumLength: 100)]
        public string Location { get; set; }

        public int? WhichFloor { get; set; }

        public int? HouseFloor { get; set; }

        public int ParkingCount { get; set; }

        public Category Category { get; set; }
        public Team Team { get; set; }
        public City City { get; set; }
        public Status Status { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<Amenity> Amenities { get; set; }




    }
}
