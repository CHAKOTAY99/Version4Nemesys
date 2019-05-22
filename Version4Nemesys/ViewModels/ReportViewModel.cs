using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Models.Enums;
using Version4Nemesys.Models;

namespace Version4Nemesys.ViewModels
{
    public class ReportViewModel
    {
        public ReportModel Report { get; set; }
        [Required]
        public int ReportID { get; set; }
        [Required]
        public string UserId { get; set; }
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
        public HazardsTest HazardsInTest { get; set; }
        public StatesTest StatusInTest { get; set; }
        //[Required]
        //public Estates States { get; set; }
        //[Required]
        //public int HazardID { get; set; }
        //[Required]
        //public EnumStates StatesInTest { get; set; }
        [Required]
        public IFormFile Photo { get; set; }

        public string PhotoLocation { get; set; }
    }
}