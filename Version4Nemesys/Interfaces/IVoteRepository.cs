using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Repositories;
using Version4Nemesys.ViewModels;
using Version4Nemesys.Models;

namespace Version4Nemesys.Interfaces
{
    public interface IVoteRepository
    {
        void AddVote(VoteViewModel VoteVM);
        IEnumerable<VoteModel> GetTotalVotes();
        IEnumerable<VoteModel> GetVotesbyReport(int id);
    }
}
