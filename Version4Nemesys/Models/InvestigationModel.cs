using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Models.Enums;

namespace Version4Nemesys.Models
{
    public class InvestigationModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int InvestigationID { get; set; }

        public virtual IdentityUser User { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get; set; }

        [Required]
        public DateTime? ActionDate { get; set; }

        [Required]
        public int ReportUsed {get; set;}
        [ForeignKey("ReportUsed")]
        public ReportModel RelatedReport { get; set; }

        [Required]
        public string InvestigationDescription { get; set; }
        
        [Required]
        public InvestigationTest InvestigationsInTest { get; set; }
    }
}