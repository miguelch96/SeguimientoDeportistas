﻿using System;
using System.Collections.Generic;
using GroupSports.DL.Actors;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSports.DL.DALI
{
    public interface IWorkWeekRepository
    {
        List<WORKWEEK> Get(int? mesociclo);
        WORKWEEK Find(int id);
        void Add(WORKWEEK workweek);
        void Edit(WORKWEEK workweek);
        void Delete(int id);

    }
}
