using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Models.Enums;

namespace Version4Nemesys.ViewModels
{
    public class AccountViewModel
    {
        /*
        [Required]
        public string UserId { get; set; }
        public virtual IdentityUser User { get; set; }
        /*
        [Required]
        public string RoleId { get; set; }
        public virtual IdentityRole Role { get; set; }
        */
        [Required]
        public Jobs JobsList { get; set; }
    }
}
