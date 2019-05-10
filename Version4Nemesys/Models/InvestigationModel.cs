using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Version4Nemesys.Models.Enums.Status;

namespace Version4Nemesys.Models
{
    public class InvestigationModel
    {
        [Required]
        [Key]
        public int InvestigationID { get; set; }
        [Required]
        public DateTime? ActionDate { get; set; }
        [Required]
        public string InvestigationDescription { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public Estates States { get; set; }

    }
}
