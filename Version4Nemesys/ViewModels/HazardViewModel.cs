using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Models;


/* THIS IS TEMPORARLY RETIRED */


namespace Version4Nemesys.ViewModels
{
    public class HazardViewModel
    {
        public HazardModel Hazard { get; set; }
        
        [Required]
        public string HazardName { get; set; }
    }
}
