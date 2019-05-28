using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            newVote.ReportID = VoteVM.ReportID;
            newVote.UserId = VoteVM.UserId;

            if (_context.Votes.Any(x => x.ReportID == newVote.ReportID && x.UserId == newVote.UserId))
            {
                    
            }
            else
            {
                _context.Votes.Add(newVote);
                _context.SaveChanges();
            }
        }

        public void RemoveVote(VoteViewModel VoteVM)
        {
            VoteModel newVote = new VoteModel();

            newVote.VoteID = VoteVM.VoteID;
            newVote.ReportID = VoteVM.ReportID;
            newVote.UserId = VoteVM.UserId;

            if (_context.Votes.Any(x => x.ReportID == newVote.ReportID && x.UserId == newVote.UserId))
            {
                _context.Votes.Remove(newVote);
                _context.SaveChanges();
            }
            //else
             //{ }
        }

        public ReportModel VoteByReport(int ReportID)
        {
            return _context.Reports.SingleOrDefault(x => x.ReportID == ReportID);
        }

    }
}
