using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Models
{
    public class Slider
    {
        public int Id { get; set; }

        public int Order { get; set; }

        [StringLength(maximumLength: 50)]
        public string Icon { get; set; }

        [StringLength(maximumLength: 100)]
        public string Subtitle { get; set; }

        [StringLength(maximumLength: 100)]
        public string Title1 { get; set; }

        [StringLength(maximumLength: 100)]
        public string Title2 { get; set; }

        [StringLength(maximumLength: 300)]
        public string Desc { get; set; }

        [StringLength(maximumLength: 100)]
        public string RedirectUrl { get; set; }

        [StringLength(maximumLength: 100)]
        public string UrlText { get; set; }

        [StringLength(maximumLength: 100)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }



    }
}
