using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Data;
using Version4Nemesys.Models;
using Version4Nemesys.Models.ViewModels;

namespace Version4Nemesys.Repositories
{
    public class HazardRepository : IHazardRepository
    {
        private ApplicationDbContext _context { get; set; }

        public HazardRepository()
        {
            this._context = new ApplicationDbContext();
        }

        public int AddHazard(HazardViewModel HazardVM)
        {
            HazardModel newHazard = new HazardModel();
            newHazard.HazardID = _context.Hazard.Count() + 1;
            newHazard.HazardName = HazardVM.HazardName;
            _context.Hazard.Add(newHazard);
            _context.SaveChanges();
            return newHazard.HazardID;
        }

        public IEnumerable<HazardModel> GetHazards()
        {
            throw new NotImplementedException();
        }

        public void RemoveHazard(int HazardID)
        {
            throw new NotImplementedException();
        }
    }
}
