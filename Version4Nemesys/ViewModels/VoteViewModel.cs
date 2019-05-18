using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Models;

namespace Version4Nemesys.ViewModels
{
    public class VoteViewModel
    {
        [Required]
        public int ReportID { get; set; }
        [Required]
        public bool Vote { get; set; }
        [Required]
        public ReportModel RelatedReport { get; set; }
    }
}
