﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL.Actors;

namespace GroupSports.DL.DALI
{
    public interface ISessionRepository
    {
        List<SESION> Get(int? workweekid);
        SESION Find(int id);
        void Add(SESION mesociclo);
        void Edit(SESION mesociclo);
        void Delete(int id);

    }
}
