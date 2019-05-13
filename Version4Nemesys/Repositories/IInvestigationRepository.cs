using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Models;
using Version4Nemesys.Models.ViewModels;

namespace Version4Nemesys.Repositories
{
    public interface IInvestigationRepository
    {
        IEnumerable<InvestigationModel> GetInvestigations();
        void AddInvestigation(InvestigationViewModel InvestigationVM);
    }
}
