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
            //newReport.States = Status.Estates.OPEN;
            //newReport.HazardID = ReportVM.HazardID;
            //newReport.HazardEnum = ReportVM.HazardEnum;
            newReport.HazardsInTest = ReportVM.HazardsInTest;
            newReport.StatesInTest = StatesTest.Open;
            _context.Reports.Add(newReport);
            _context.SaveChanges();
        }

        public IEnumerable<ReportModel> GetReports()
        {
            return _context.Reports.ToList();
        }
    }
}
