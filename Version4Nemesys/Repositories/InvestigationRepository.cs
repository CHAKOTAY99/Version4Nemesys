using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Data;
using Version4Nemesys.Models;
using Version4Nemesys.ViewModels;
using Version4Nemesys.Models.Enums;
using Microsoft.AspNetCore.Identity;

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
            var investigation = InvestigationByReport(InvestigationVM.ReportUsed);
            if(investigation == null)
            {
                InvestigationModel newInvestigation = new InvestigationModel();
                newInvestigation.ActionDate = DateTime.Now;
                newInvestigation.RelatedReport = InvestigationVM.RelatedReport;
                newInvestigation.InvestigationDescription = InvestigationVM.InvestigationDescription;
                newInvestigation.InvestigationsInTest = InvestigationTest.Open;
                newInvestigation.RelatedReport = InvestigationVM.RelatedReport;
                newInvestigation.ReportUsed = InvestigationVM.ReportUsed;
                newInvestigation.UserId = InvestigationVM.UserId;
                newInvestigation.User = GetUser(InvestigationVM.UserId);

                _context.Investigations.Add(newInvestigation);
                _context.SaveChanges();
            }
        }

        public void EditInvestigation(InvestigationViewModel InvestigationVM)
        {
            InvestigationModel ToChange = GetInvestigationDetails(InvestigationVM.InvestigationID);
            //InvestigationModel ToChange = _context.Investigations.SingleOrDefault(x => x.InvestigationID == InvestigationVM.InvestigationID);
            //InvestigationModel ToChange = new InvestigationModel();
            ToChange.ActionDate = DateTime.Now;
            //ToChange.RelatedReport = InvestigationVM.RelatedReport;
            ToChange.InvestigationDescription = InvestigationVM.InvestigationDescription;
            ToChange.InvestigationsInTest = InvestigationVM.InvestigationsInTest;
            //ToChange.RelatedReport = InvestigationVM.RelatedReport;
            //ToChange.ReportUsed = InvestigationVM.ReportUsed;
            _context.Investigations.Update(ToChange);
            _context.SaveChanges();
        }

        public ReportModel InvestigationByReport(int ReportID)
        {
            return _context.Reports.SingleOrDefault(x => x.ReportID == ReportID);
        }

        public InvestigationModel GetInvestigationDetails(int InvestigtaionID)
        {
            return _context.Investigations.SingleOrDefault(x => x.InvestigationID == InvestigtaionID);
        }

        public IdentityUser GetUser(string userID)
        {
            return _context.Users.SingleOrDefault(x => x.Id.Equals(userID));
        }
    }
}
