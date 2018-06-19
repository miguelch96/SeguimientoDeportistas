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
    public class MesocicloRepository : IMesocicloRepository
    {
        public List<MESOCICLO> Get(int? macrocicloid)
        {
            using (GSEntities entities = new GSEntities())
            {
                IQueryable<MESOCICLO> mesociclos = entities.MESOCICLO.Where(x=>x.MACROCICLO.Estado && x.Estado);
                if (macrocicloid.HasValue)
                {
                    mesociclos = mesociclos.Where(x => x.MACROCICLO.MacrocicloId == macrocicloid);
                }
                return mesociclos.ToList();
            }
        }

        public MESOCICLO Find(int id)
        {
            using (GSEntities entities = new GSEntities())
            {
                return entities.MESOCICLO.Find(id);
            }
        }

        public void Add(MESOCICLO mesociclo)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    mesociclo.Estado = true;
                    entities.MESOCICLO.Add(mesociclo);
                    entities.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Edit(MESOCICLO mesociclo)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    var mesocicloInDb = entities.MESOCICLO.Find(mesociclo.MesocicloId);
                    if (mesocicloInDb != null)
                    {
                        mesocicloInDb.Name = mesociclo.Name;
                        mesocicloInDb.Objective = mesociclo.Objective;
                        mesocicloInDb.FechaInicio = mesociclo.FechaInicio;
                        mesocicloInDb.FechaFin = mesociclo.FechaFin;
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
