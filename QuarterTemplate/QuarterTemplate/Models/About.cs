using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Models
{
    public class About
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 100)]
        public string Icon { get; set; }
    }
}
