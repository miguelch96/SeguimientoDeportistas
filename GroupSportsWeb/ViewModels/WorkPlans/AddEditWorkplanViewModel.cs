﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GroupSports.DL;

namespace GroupSportsWeb.ViewModels.WorkPlans
{
    public class AddEditWorkplanViewModel
    {
        public int? WorkPlanId { get; set; }

        [Required]
        public string Name { get; set; } = String.Empty;

        [Required]
        public string Objective { get; set; } = String.Empty;

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        //public int CoachId { get; set; }

        //public List<COACH> LstCoachs { get; set; } = new List<COACH>();

        public void CargarDatos(WORKPLAN workplan)
        {
            WorkPlanId = workplan.WorkPlanId;
            Name = workplan.Name;
            Objective = workplan.Objective;
            FechaInicio = workplan.FechaInicio.Value;
            FechaFin = workplan.FechaFin.Value;
        }
    }
}