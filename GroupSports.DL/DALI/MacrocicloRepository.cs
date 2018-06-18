using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSports.DL.DALI
{
    public class MacrocicloRepository : IMacrocicloRepository
    {
        public List<MACROCICLO> Get()
        {
            using (GSEntities entities = new GSEntities())
            {
                return entities.MACROCICLO.ToList();
            }
        }

        public List<MACROCICLO> GetByWorkplan(int macrocicloid)
        {
            using (GSEntities entities = new GSEntities())
            {
                return entities.MACROCICLO.Where(x => x.WorkPlanId == macrocicloid).ToList();
            }
        }

        public MACROCICLO Get(int id)
        {
            using (GSEntities entities = new GSEntities())
            {
                return entities.MACROCICLO.Find(id);
            }
        }

        public void Add(MACROCICLO macrociclo)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    macrociclo.Estado = true;
                    entities.MACROCICLO.Add(macrociclo);
                    entities.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Edit(MACROCICLO macrociclo)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    var macrocicloInDb = entities.MACROCICLO.Find(macrociclo.MacrocicloId);
                    if (macrocicloInDb != null)
                    {
                        macrocicloInDb.Name = macrociclo.Name;
                        macrocicloInDb.Objective = macrociclo.Objective;
                        macrocicloInDb.FechaInicio = macrociclo.FechaInicio;
                        macrocicloInDb.FechaFin = macrociclo.FechaFin;

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
                    var macrociclo = entities.MACROCICLO.Find(id);
                    if (macrociclo != null)
                    {
                        macrociclo.Estado = false;
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

