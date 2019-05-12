using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Version4Nemesys.Models.ViewModels
{
    public class HazardViewModel
    {
        public HazardModel Hazard { get; set; }
        
        [Required]
        public string HazardName { get; set; }
    }
}
