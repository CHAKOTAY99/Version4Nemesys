using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Models;

namespace Version4Nemesys.ViewModels
{
    public class HallOfFameViewModel
    {
        public string UserId { get; set; }

        public string Email { get; set; }

        [Required]
        public IdentityUser User { get; set; }

        [Required]
        public int Counter { get; set; }
    }
}
