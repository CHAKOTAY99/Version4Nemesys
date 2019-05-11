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
        private readonly ApplicationDbContext _context;

        public HazardRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //private readonly IHazardRepository _repository;

        //public HazardRepository(IHazardRepository repository)
        //{
        //    _repository = repository;
        //}

        public int AddHazard(HazardViewModel HazardVM)
        {
            HazardModel newHazard = new HazardModel();
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
