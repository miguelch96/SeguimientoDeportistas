﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL.Actors;

namespace GroupSports.DL.DALI
{
    public interface IMesocicloRepository
    {
        List<MESOCICLO> Get(int? macrocicloid);
        MESOCICLO Find(int id);
        void Add(MESOCICLO mesociclo);
        void Edit(MESOCICLO mesociclo);
        void Delete(int id);
    }
}
