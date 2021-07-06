using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class ProductsGg
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The Sku value cannot exceed 100 characters. ")]
        public string Sku { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The Title value cannot exceed 100 characters. ")]
        public string Title { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "The Description value cannot exceed 200 characters. ")]
        public string Description { get; set; }
        [Required]
        [StringLength(300, ErrorMessage = "The ImageUrl value cannot exceed 300 characters. ")]
        public string ImageUrl { get; set; }

        [ScaffoldColumn(false)]
        public string UserName { get; set; }
    }
}
