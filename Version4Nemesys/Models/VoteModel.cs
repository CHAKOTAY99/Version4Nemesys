using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Version4Nemesys.Models
{
    public class VoteModel
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int VoteID { get; set; }

        [Required]
        public int ReportID { get; set; }
        [ForeignKey("ReportID")]
        public ReportModel RelatedReport { get; set; }

        [Required]
        public bool Voted { get; set; }
        [Required]
        public int TotalVotes { get; set; }
    }
}
