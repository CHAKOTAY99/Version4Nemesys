using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Data;
using Version4Nemesys.Interfaces;
using Version4Nemesys.Models;
using Version4Nemesys.ViewModels;

namespace Version4Nemesys.Repositories
{
    public class VoteRepository : IVoteRepository
    {
        private readonly ApplicationDbContext _context;

        public VoteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddVote(VoteViewModel VoteVM)
        {
            VoteModel newVote = new VoteModel();

        }

        public IEnumerable<VoteModel> GetTotalVotes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VoteModel> GetVotesbyReport(int id)
        {
            throw new NotImplementedException();
        }
    }
}
