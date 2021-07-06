using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class GgUserInfo
    {
        [ScaffoldColumn(false)]

        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The RoleUsername value cannot exceed 100 characters. ")]
        public string RoleUsername { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The RolePassword value cannot exceed 100 characters. ")]
        public string RolePassword { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The ApiKey value cannot exceed 100 characters. ")]
        public string ApiKey { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The SecretKey value cannot exceed 100 characters. ")]
        public string SecretKey { get; set; }
        [ScaffoldColumn(false)]
        public string UserName { get; set; }
    }
}
