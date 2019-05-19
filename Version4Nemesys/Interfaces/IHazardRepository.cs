﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version4Nemesys.Models;
using Version4Nemesys.ViewModels;

namespace Version4Nemesys.Repositories
{
    public interface IHazardRepository
    {
        IEnumerable<HazardModel> GetHazards();
        void AddHazard(HazardViewModel HazardVM);
    }
}
