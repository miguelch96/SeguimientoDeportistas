using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GroupSports.DL;

namespace GroupSportsWeb.ViewModels.WorkWeeks
{
    public class AddEditWorkWeekViewModel
    {
        public int? WorkWeekId { get; set; }

        public int MesocicloId { get; set; }

        [Required]
        public string Name { get; set; } = String.Empty;

        [Required]
        public string Objective { get; set; } = String.Empty;

        public DateTime FechaInicio { get; set; } = DateTime.Today;

        public DateTime FechaFin { get; set; } = DateTime.Today.AddDays(5);

        public bool Estado { get; set; } = true;

        public List<MESOCICLO> LstMesociclos { get; set; } = new List<MESOCICLO>();

        public void CargarDatos(WORKWEEK workweek)
        {
            WorkWeekId = workweek.WorkWeekId;
            MesocicloId = workweek.MESOCICLO.MesocicloId;
            Name = workweek.Nombre;
            Objective = workweek.Objective;
            FechaInicio = workweek.FechaInicio.Value;
            FechaFin = workweek.FechaFin.Value;
            Estado = workweek.Estado;
        }
    }
}