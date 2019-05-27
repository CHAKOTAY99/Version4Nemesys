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

        [Required]
        public int Co { get; set; }
    }
}
