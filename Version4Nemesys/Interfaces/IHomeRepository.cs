using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Models;

namespace Version4Nemesys.Interfaces
{
    public interface IHomeRepository
    {
        IEnumerable<UserModel> GetLeaderboard();
    }
}
