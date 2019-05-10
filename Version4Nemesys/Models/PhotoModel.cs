using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Version4Nemesys.Models
{
    public class PhotoModel
    {
        [Required]
        [Key]
        public int PhotoID { get; set; }
        [Required]
        public string PhotoName { get; set; }
        [Required]
        public string PhotoPath { get; set; }
    }
}
