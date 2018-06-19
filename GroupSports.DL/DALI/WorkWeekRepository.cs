using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GroupSports.DL.Actors;

namespace GroupSports.DL.DALI
{
    public class WorkWeekRepository : IWorkWeekRepository
    {
        public List<WORKWEEK> Get(int? mesocicloid)
        {
            using (GSEntities entities = new GSEntities())
            {
                IQueryable<WORKWEEK> workweeks = entities.WORKWEEK.Where(x=>x.MESOCICLO.Estado && x.Estado);
                if (mesocicloid.HasValue)
                {
                    workweeks = workweeks.Where(x => x.MESOCICLO.MesocicloId == mesocicloid);
                }
                return workweeks.ToList();
            }
        }

        public WORKWEEK Find(int id)
        {
            using (GSEntities entities = new GSEntities())
            {
                return entities.WORKWEEK.Find(id);
            }
        }

        public void Add(WORKWEEK workweek)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    workweek.Estado = true;
                    entities.WORKWEEK.Add(workweek);
                    entities.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Edit(WORKWEEK workweek)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    var workweekInDb = entities.WORKWEEK.Find(workweek.WorkWeekId);
                    if (workweekInDb != null)
                    {
                        workweekInDb.Nombre = workweek.Nombre;
                        workweekInDb.Objective = workweek.Objective;
                        workweekInDb.FechaInicio = workweek.FechaInicio;
                        workweekInDb.FechaFin = workweek.FechaFin;
                        workweekInDb.MesocicloId = workweek.MesocicloId;
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

        public void Delete(int id)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    var mesociclo = entities.MESOCICLO.Find(id);
                    if (mesociclo != null)
                    {
                        mesociclo.Estado = false;
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
