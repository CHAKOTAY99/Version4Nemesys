using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Data;
using Version4Nemesys.Models.Enums;
using Version4Nemesys.Models;
using Version4Nemesys.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Version4Nemesys.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ReportRepository(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public void AddReport(ReportViewModel ReportVM)
        {
            ReportModel newReport = new ReportModel();

            newReport.ReportName = ReportVM.ReportName;
            newReport.EventDate = ReportVM.EventDate;
            newReport.ReportDate = DateTime.Now;
            newReport.EventLocation = ReportVM.EventLocation;
            newReport.EventDescription = ReportVM.EventDescription;
            newReport.HazardsInTest = ReportVM.HazardsInTest;
            newReport.StatesInTest = StatesTest.Open;
            newReport.PhotoPath = ReportVM.PhotoLocation;
            newReport.UserId = ReportVM.UserId;
            
            // First check if one exists
            if (UserFind(ReportVM.UserId) == null) {
                UserModel newUser = new UserModel();
                newUser.Counter = newUser.Counter + 1;
                newUser.UserId = ReportVM.UserId;
                _context.UserCounter.Add(newUser);
            } else
            {
                UserModel ToChange = UserFind(ReportVM.UserId);
                ToChange.Counter = ToChange.Counter + 1;
                _context.UserCounter.Update(ToChange);
            }

            _context.Reports.Add(newReport);
            _context.SaveChanges();
        }

        public IEnumerable<ReportModel> GetReports()
        {
            return _context.Reports.ToList();
        }

        public ReportModel ShowReportDetails(int ReportID)
        {
            return _context.Reports.SingleOrDefault(x => x.ReportID == ReportID);
        }

        public UserModel UserFind(string UserId)
        {
            return _context.UserCounter.SingleOrDefault(x => x.UserId.Equals(UserId));
        }
    }
}
