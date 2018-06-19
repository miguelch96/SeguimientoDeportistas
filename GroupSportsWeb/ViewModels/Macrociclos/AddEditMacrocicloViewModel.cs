using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GroupSports.DL;

namespace GroupSportsWeb.ViewModels.Macrociclos
{
    public class AddEditMacrocicloViewModel
    {
        public int? MacrocicloId { get; set; }

        public int WorkplanId { get; set; }

        [Required]
        public string Name { get; set; } = String.Empty;

        [Required]
        public string Objective { get; set; } = String.Empty;

        public DateTime FechaInicio { get; set; } = DateTime.Today;

        public DateTime FechaFin { get; set; } = DateTime.Today.AddDays(5);

        public bool Estado { get; set; } = true;

        public List<WORKPLAN> LstWorkplans { get; set; } = new List<WORKPLAN>();

        public void CargarDatos(MACROCICLO macrociclo)
        {
            MacrocicloId = macrociclo.MacrocicloId;
            WorkplanId = macrociclo.WORKPLAN.WorkPlanId;
            Name = macrociclo.Name;
            Objective = macrociclo.Objective;
            FechaInicio = macrociclo.FechaInicio.Value;
            FechaFin = macrociclo.FechaFin.Value;
            Estado = macrociclo.Estado;
        }
    }
}