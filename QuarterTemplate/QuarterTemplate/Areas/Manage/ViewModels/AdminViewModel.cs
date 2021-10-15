using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Areas.Manage.ViewModels
{
    public class AdminViewModel
    {
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 6, ErrorMessage = "UserName min 6, max 50 ola biler")]
        public string UserName { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 6, ErrorMessage = "FullName min 6, max 50 ola biler")]
        public string FullName { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 6, ErrorMessage = "Email min 6, max 50 ola biler")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 6, ErrorMessage = "Sifreniz min 6, max 30 ola biler")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
