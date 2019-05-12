using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Data;
using Version4Nemesys.Models.Enums;
using Version4Nemesys.Models;
using Version4Nemesys.Models.ViewModels;

namespace Version4Nemesys.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly ApplicationDbContext _context;

        public ReportRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddReport(ReportViewModel ReportVM)
        {
            ReportModel newReport = new ReportModel();
            newReport.ReportName = ReportVM.ReportName;
            newReport.EventDate = ReportVM.EventDate;
            newReport.ReportDate = DateTime.Now;
            newReport.EventLocation = ReportVM.EventLocation;
            newReport.EventDescription = ReportVM.EventDescription;
            newReport.States = Status.Estates.OPEN;
        }

        public IEnumerable<ReportModel> GetReports()
        {
            throw new NotImplementedException();
        }


        public void AddHazard(HazardViewModel HazardVM)
        {
            HazardModel newHazard = new HazardModel();
            newHazard.HazardName = HazardVM.HazardName;
            _context.Hazard.Add(newHazard);
            _context.SaveChanges();
        }

        public IEnumerable<HazardModel> GetHazards()
        {
            return _context.Hazard.ToList();
        }
    }
}
