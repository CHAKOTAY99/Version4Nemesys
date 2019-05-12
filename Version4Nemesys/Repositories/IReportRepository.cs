using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Models;
using Version4Nemesys.Models.ViewModels;

namespace Version4Nemesys.Repositories
{
    public interface IReportRepository
    {
        IEnumerable<ReportModel> GetReports();
        void AddReport(ReportViewModel ReportVM);
    }
}
