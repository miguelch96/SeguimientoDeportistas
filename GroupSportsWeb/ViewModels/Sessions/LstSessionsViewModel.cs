﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupSports.DL;

namespace GroupSportsWeb.ViewModels.Sessions
{
    public class LstSessionsViewModel
    {
        public List<SESION> LstSessions { get; set; }
        public WORKWEEK Workweek { get; set; }
    }
}