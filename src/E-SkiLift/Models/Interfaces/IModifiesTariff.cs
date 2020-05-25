﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_SkiLift.Models.Interfaces
{
    public interface IModifiesTariff
    {
        bool SkiLiftExists(int id);
        int GetCurrentLiftPointCost(int id);
        bool UpdateLiftTariff(int id, int newPointCost, System.DateTime newBeginDate);
    }
}
