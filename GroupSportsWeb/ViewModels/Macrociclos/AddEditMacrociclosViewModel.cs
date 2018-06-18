using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GroupSports.DL;

namespace GroupSportsWeb.ViewModels.Macrociclos
{
    public class AddEditMacrociclosViewModel
    {
        public int? MacrocicloId { get; set; }

        public int WorkplanId { get; set; }

        [Required]
        public string Name { get; set; } = String.Empty;

        [Required]
        public string Objective { get; set; } = String.Empty;

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public List<COACH> LstCoachs { get; set; } = new List<COACH>();

        public bool Estado { get; set; } = true;

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