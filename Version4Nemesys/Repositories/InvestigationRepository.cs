using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Data;
using Version4Nemesys.Models;
using Version4Nemesys.ViewModels;
using Version4Nemesys.Models.Enums;

namespace Version4Nemesys.Repositories
{
    public class InvestigationRepository : IInvestigationRepository
    {
        private readonly ApplicationDbContext _context;

        public InvestigationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<InvestigationModel> GetInvestigations()
        {
            return _context.Investigations.ToList();
        }
        public void AddInvestigation(InvestigationViewModel InvestigationVM)
        {
            InvestigationModel newInvestigation = new InvestigationModel();
            newInvestigation.ActionDate = DateTime.Now;
            newInvestigation.RelatedReport = InvestigationVM.RelatedReport;
            newInvestigation.InvestigationDescription = InvestigationVM.InvestigationDescription;
            newInvestigation.InvestigationsInTest = InvestigationTest.Open;
            newInvestigation.RelatedReport = InvestigationVM.RelatedReport;
            newInvestigation.ReportUsed = InvestigationVM.ReportUsed;
            _context.Investigations.Add(newInvestigation);
            _context.SaveChanges();
        }

        public ReportModel InvestigationByReport(int ReportID)
        {
            return _context.Reports.SingleOrDefault(x => x.ReportID == ReportID);
        }
    }
}
