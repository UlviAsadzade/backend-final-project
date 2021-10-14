using QuarterTemplate.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }

        public int? ProductId { get; set; }

        [StringLength(maximumLength: 100)]
        public string ProductName { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }

        [StringLength(maximumLength: 250)]
        public string Address { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }

        public OrderStatus Status { get; set; }


        public Product Product { get; set; }

        public AppUser AppUser { get; set; }
    }
}
