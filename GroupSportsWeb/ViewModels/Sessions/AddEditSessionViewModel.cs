using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GroupSports.DL;

namespace GroupSportsWeb.ViewModels.Sessions
{
    public class AddEditSessionViewModel
    {
        public int? SessionId { get; set; }

        public int WorkWeekId { get; set; }

        [Required]
        public string Name { get; set; } = String.Empty;

        [Required]
        public string Objective { get; set; } = String.Empty;

        public DateTime RegisterDate { get; set; } = DateTime.Today;

        public bool Asistencia { get; set; } = false;

        public bool Cumplimiento { get; set; } = false;

        public TimeSpan HoraAsistencia { get; set; }
        public TimeSpan HoraCumplimiento { get; set; } 

        public String Bitacora { get; set; } = String.Empty;

        public bool Estado { get; set; } = true;

        public List<WORKWEEK> LstWorkweeks { get; set; } = new List<WORKWEEK>();

        public void CargarDatos(SESION sesion)
        {
            SessionId = sesion.SesionId;
            WorkWeekId = sesion.WORKWEEK.WorkWeekId;
            Name = sesion.Nombre;
            Objective = sesion.Objective;
            RegisterDate = sesion.RegisterDate.Value;
            Asistencia = sesion.Asistencia.Value;
            Cumplimiento = sesion.Cumplimiento.Value;
            HoraAsistencia = sesion.HoraAsistencia.Value;
            HoraCumplimiento = sesion.HoraCumplimiento.Value;
            Bitacora = sesion.Bitacora;
            Estado = sesion.Estado;
        }
    }
}