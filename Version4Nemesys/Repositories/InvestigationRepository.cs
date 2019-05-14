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

        public IEnumerable<InvestigationModel> GetInvestigations()
        {
            //throw new NotImplementedException();
            return _context.Investigations.ToList();
        }
        public void AddInvestigation(InvestigationViewModel InvestigationVM, int id)
        {
            InvestigationModel newInvestigation = new InvestigationModel();
            newInvestigation.ActionDate = DateTime.Now;
            newInvestigation.ReportUsed = id;
            newInvestigation.InvestigationDescription = InvestigationVM.InvestigationDescription;
            _context.Investigations.Add(newInvestigation);
            _context.SaveChanges();
        }
    }
}
