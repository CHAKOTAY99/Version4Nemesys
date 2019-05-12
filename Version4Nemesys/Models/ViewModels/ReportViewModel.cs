using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Version4Nemesys.Models.Enums.Status;

namespace Version4Nemesys.Models.ViewModels
{
    public class ReportViewModel
    {
        public ReportModel Report { get; set; }
        [Required]
        public int ReportID { get; set; }
        [Required]
        public string ReportName { get; set; }
        [Required]
        public DateTime? EventDate { get; set; }
        [Required]
        public DateTime? ReportDate { get; set; }
        [Required]
        public string EventLocation { get; set; }
        [Required]
        public string EventDescription { get; set; }
        [Required]
        public Estates States { get; set; }
    }
}
