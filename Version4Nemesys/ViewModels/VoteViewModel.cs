using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Version4Nemesys.ViewModels
{
    public class VoteViewModel
    {
        [Required]
        public int ReportID { get; set; }
        [Required]
        public bool Vote { get; set; }
    }
}
