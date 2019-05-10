using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Version4Nemesys.Models.Enums.Status;

namespace Version4Nemesys.Models
{
    public class ReportModel
    {
        [Required]
        [Key]
        public int ReportID { get; set; }
        [Required]
        public DateTime? EventDate { get; set; }
        [Required]
        public DateTime? ReportDate { get; set; }
        [Required]
        public int HazardID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public string EventLocation { get; set; }
        [Required]
        public string EventDescription { get; set; }
        public int PhotoID { get; set; }
        [Required]
        public int ReportUpvotes { get; set; }
        [Required]
        public Estates States { get; set; }
        public HazardModel HazardsModel { get; set; }
        // public RegisterModel RegisterModel { get; set; }
        public PhotoModel PhotoModel { get; set; }
    }
}
