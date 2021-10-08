using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Models
{
    public class Team
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 100)]
        public string Image { get; set; }

        [StringLength(maximumLength: 100)]
        public string FullName { get; set; }

        [StringLength(maximumLength: 300)]
        public string Desc { get; set; }

        

     
    }
}
