using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Data;
using Version4Nemesys.Models;
using Version4Nemesys.Models.ViewModels;

namespace Version4Nemesys.Repositories
{
    public class InvestigationRepository : IInvestigationRepository
    {
        private readonly ApplicationDbContext _context;

        public InvestigationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        IEnumerable<InvestigationModel> GetInvestigations()
        {
            return _context.Investigations.ToList();
        }
        void AddInvestigation(InvestigationViewModel InvestigationVM)
        {
            // TODO
        }


    }
}
