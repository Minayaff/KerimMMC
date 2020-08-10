using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KerimMMC.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad yeri boş qala bilməz")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Min 6 hərf olmalı")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Email yeri boş qala bilməz")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Min 5 hərf olmalı")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Mesaj yeri boş qala bilməz")]
        public string Message { get; set; }

    }
}
