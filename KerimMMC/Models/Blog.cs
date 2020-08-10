using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KerimMMC.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [StringLength(200)]
        [Required(ErrorMessage = "Şəkil seçin"), MinLength(10)]
        public string Image { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
        [Required(ErrorMessage ="Texti doldurun"),MinLength(10)]
        public string Text { get; set; }
        [Required(ErrorMessage = "Başlığı doldurun"), MinLength(6)]
        public string HeadText { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
