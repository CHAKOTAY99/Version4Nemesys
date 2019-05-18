using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Models.Enums;

namespace Version4Nemesys.Models.ViewModels
{
    public class InvestigationViewModel
    {
        [Required]
        public int InvestigationID { get; set; }
        [Required]
        public DateTime? ActionDate { get; set; }
        [Required]
        public int ReportUsed { get; set; }
        [ForeignKey("ReportUsed")]
        public ReportModel RelatedReport { get; set; }
        [Required]
        public string InvestigationDescription { get; set; }

        public StatesTest StatusInTest { get; set; }
        //[Required]
        //public Estates States { get; set; }
    }
}
