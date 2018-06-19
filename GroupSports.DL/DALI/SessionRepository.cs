using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL.Actors;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GroupSports.DL.DALI
{
    public class SessionRepository : ISessionRepository
    {
        public List<SESION> Get(int? workweekid)
        {
            using (GSEntities entities = new GSEntities())
            {
                IQueryable<SESION> sesions = entities.SESION.Where(x=>x.WORKWEEK.Estado && x.Estado);
                if (workweekid.HasValue)
                {
                    sesions = sesions.Where(x => x.WORKWEEK.WorkWeekId == workweekid);
                }
                return sesions.ToList();
            }
        }

        public SESION Find(int id)
        {
            using (GSEntities entities = new GSEntities())
            {
                return entities.SESION.Find(id);
            }
        }

        public void Add(SESION sesion)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    sesion.Estado = true;
                    sesion.RegisterDate = DateTime.Now;
                    entities.SESION.Add(sesion);
                    entities.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Edit(SESION sesion)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    var sesionInDb = entities.SESION.Find(sesion.SesionId);
                    if (sesionInDb == null)
                        return;

                    sesionInDb.Nombre = sesion.Nombre;
                    sesionInDb.Objective = sesion.Objective;
                    sesionInDb.Asistencia = sesion.Asistencia;
                    sesionInDb.Cumplimiento = sesion.Cumplimiento;
                    sesionInDb.HoraAsistencia = sesion.HoraAsistencia;
                    sesionInDb.HoraCumplimiento = sesion.HoraCumplimiento;
                    sesionInDb.Bitacora = sesion.Bitacora;
                    entities.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    var sesion = entities.SESION.Find(id);
                    if (sesion != null)
                    {
                        sesion.Estado = false;
                        entities.SaveChanges();
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
