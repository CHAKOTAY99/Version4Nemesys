using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Version4Nemesys.Models
{
    public class VoteModel
    {
        [Key]
        [Required]
        public int ReportID { get; set; }
        [Required]
        public int userID { get; set; }
        [Required]
        public bool vote { get; set; }
    }
}
