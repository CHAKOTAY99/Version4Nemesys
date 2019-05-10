using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Version4Nemesys.Models
{
    public class HazardModel
    {
        [Required]
        [Key]
        public int HazardID { get; set; }
        [Required]
        public string HazardName { get; set; }
    }
}
