﻿using System;
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
        public VoteModel Vote { get; set; }
        [Required]
        public int ReportID { get; set; }
        [Required]
        public bool Voted { get; set; }
        public ReportModel RelatedReport { get; set; }
    }
}
