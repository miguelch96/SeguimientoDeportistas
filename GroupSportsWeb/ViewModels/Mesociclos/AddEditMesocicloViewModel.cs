using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GroupSports.DL;

namespace GroupSportsWeb.ViewModels.Mesociclos
{
    public class AddEditMesocicloViewModel
    {
        public int? MesocicloId { get; set; }

        public int MacrocicloId { get; set; }

        [Required]
        public string Name { get; set; } = String.Empty;

        [Required]
        public string Objective { get; set; } = String.Empty;

        public DateTime FechaInicio { get; set; } = DateTime.Today;

        public DateTime FechaFin { get; set; } = DateTime.Today.AddDays(5);

        public bool Estado { get; set; } = true;

        public List<MACROCICLO> LstMacrociclos { get; set; } = new List<MACROCICLO>();

        public void CargarDatos(MESOCICLO mesociclo)
        {
            MesocicloId = mesociclo.MacrocicloId;
            MacrocicloId = mesociclo.MACROCICLO.MacrocicloId;
            Name = mesociclo.Name;
            Objective = mesociclo.Objective;
            FechaInicio = mesociclo.FechaInicio.Value;
            FechaFin = mesociclo.FechaFin.Value;
            Estado = mesociclo.Estado;
        }
    }
}