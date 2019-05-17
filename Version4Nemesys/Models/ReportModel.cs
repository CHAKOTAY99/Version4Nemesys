using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Models.Enums;

namespace Version4Nemesys.Models
{
    public class ReportModel
    {
        [Required]
        [Key]
        public int ReportID { get; set; }

        [Required]
        public string ReportName { get; set; }

        [Required]
        public DateTime? EventDate { get; set; }

        [Required]
        public DateTime? ReportDate { get; set; }

        //[Required]
        //public int HazardID { get; set; }
        //[ForeignKey("HazardID")]
        //public HazardModel RelatedHazard { get; set; }

        [Required]
        public string EventLocation { get; set; }

        [Required]
        public string EventDescription { get; set; }

        /*
        [Required]
        public Estates States { get; set; }
        [Required]
        public Ehazards HazardEnum { get; set; }
        */

        [Required]
        public StatesTest StatesInTest { get; set; }

        [Required]
        public HazardsTest HazardsInTest { get; set; }
        // public RegisterModel RegisterModel { get; set; }

        public string PhotoPath { get; set; }
    }
}