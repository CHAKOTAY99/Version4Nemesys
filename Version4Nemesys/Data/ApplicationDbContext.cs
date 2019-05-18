using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Version4Nemesys.Models;

namespace Version4Nemesys.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<HazardModel> Hazard { get; set; }
        public DbSet<InvestigationModel> Investigations { get; set; }
        public DbSet<ReportModel> Reports { get; set; }
        public DbSet<VoteModel> Votes { get; set; }
    }
}
