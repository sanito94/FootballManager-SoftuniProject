﻿using FootballManager_SoftuniProject.Core.Models.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Contracts.Manager
{
    public interface IManagerService
    {
        Task<bool> ExistsById(string userId);

    }
}
