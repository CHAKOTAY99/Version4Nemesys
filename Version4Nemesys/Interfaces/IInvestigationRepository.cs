using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Models;
using Version4Nemesys.ViewModels;

namespace Version4Nemesys.Repositories
{
    public interface IInvestigationRepository
    {
        IEnumerable<InvestigationModel> GetInvestigations();
        void AddInvestigation(InvestigationViewModel InvestigationVM);
        void EditInvestigation(InvestigationViewModel InvestigationVM);
        ReportModel InvestigationByReport(int ReportID);
        InvestigationModel GetInvestigationDetails(int InvestigationID);
        IdentityUser GetUser(string userID);
    }
}
