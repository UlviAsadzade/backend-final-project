using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Models
{
    public class Setting
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 100)]
        public string HeaderLogo { get; set; }

        [StringLength(maximumLength: 100)]
        public string FooterLogo { get; set; }

        [StringLength(maximumLength: 50)]
        public string Phone1 { get; set; }

        [StringLength(maximumLength: 50)]
        public string Phone2 { get; set; }

        [StringLength(maximumLength: 100)]
        public string Email1 { get; set; }

        [StringLength(maximumLength: 100)]
        public string Email2 { get; set; }

        [StringLength(maximumLength: 250)]
        public string Address { get; set; }

        [StringLength(maximumLength: 100)]
        public string LocationIcon { get; set; }

        [StringLength(maximumLength: 100)]
        public string LocationImage { get; set; }

        [StringLength(maximumLength: 100)]
        public string PhoneIcon { get; set; }

        [StringLength(maximumLength: 100)]
        public string PhoneImage { get; set; }

        [StringLength(maximumLength: 100)]
        public string EmailIcon { get; set; }

        [StringLength(maximumLength: 100)]
        public string EmailImage { get; set; }

        [StringLength(maximumLength: 100)]
        public string FacebookIcon { get; set; }

        [StringLength(maximumLength: 100)]
        public string TwitterIcon { get; set; }

        [StringLength(maximumLength: 100)]
        public string LinkedinIcon { get; set; }

        [StringLength(maximumLength: 100)]
        public string YoutubeIcon { get; set; }

        [StringLength(maximumLength: 100)]
        public string AboutImage1 { get; set; }

        [StringLength(maximumLength: 100)]
        public string AboutImage2 { get; set; }

        [StringLength(maximumLength: 100)]
        public string AboutTitle { get; set; }

        [StringLength(maximumLength: 300)]
        public string AboutDesc { get; set; }

        [StringLength(maximumLength: 100)]
        public string AboutText { get; set; }

        [StringLength(maximumLength: 100)]
        public string AboutRedirrectUrl { get; set; }

        [StringLength(maximumLength: 100)]
        public string AboutUrlText { get; set; }

       


    }
}
