﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL.Actors;


namespace GroupSports.BL.BC
{
    public interface IAthleteService
    {
        List<Athlete> findAll();
    }
}
