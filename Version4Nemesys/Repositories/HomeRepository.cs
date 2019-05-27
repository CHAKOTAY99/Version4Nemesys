using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Data;
using Version4Nemesys.Interfaces;
using Version4Nemesys.Models;

namespace Version4Nemesys.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _context;
        public HomeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UserModel> GetLeaderboard()
        {
            return _context.UserCounter.ToList();
        }
    }
}
