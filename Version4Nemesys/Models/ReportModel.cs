using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static Version4Nemesys.Models.Enums.Status;

namespace Version4Nemesys.Models
{
    public class ReportModel : IdentityUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReportID { get; set; }

        public string UserID { get; set; }
        [ForeignKey("Id")]
        public IdentityUser RelatedUser { get; set; }

        
        
        [Required]
        public string ReportName { get; set; }
        [Required]
        public DateTime? EventDate { get; set; }
        [Required]
        public DateTime? ReportDate { get; set; }
        // [Required]
        public int HazardID { get; set; }
        [ForeignKey("HazardID")]
        public HazardModel RelatedHazard { get; set; }
        [Required]
        public string EventLocation { get; set; }
        [Required]
        public string EventDescription { get; set; }
        public int PhotoID { get; set; }
        [ForeignKey("PhotoID")]
        public PhotoModel RelatedPhoto { get; set; }
        // [Required]
        public Estates States { get; set; }
        // public RegisterModel RegisterModel { get; set; }
    }
}
