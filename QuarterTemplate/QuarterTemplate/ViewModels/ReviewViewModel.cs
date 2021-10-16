using QuarterTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.ViewModels
{
    public class ReviewViewModel
    {
        public Product Product { get; set; }
        public List<Review> Reviews { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Text { get; set; }
        public int Rate { get; set; }
        public Order Order { get; set; }
    }
}
