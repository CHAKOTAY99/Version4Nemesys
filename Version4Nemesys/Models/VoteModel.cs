using Microsoft.AspNetCore.Identity;
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
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int VoteID { get; set; }
        
        [Required]
        public virtual ReportModel RelatedReport { get; set; }
        [ForeignKey("ReportID")]
        public int ReportID { get; set; }
        
        [Required]
        public virtual IdentityUser User { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get; set; }
    }
}
