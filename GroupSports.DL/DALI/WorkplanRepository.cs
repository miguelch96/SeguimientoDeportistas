using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSports.DL.DALI
{
    public class WorkplanRepository : IWorkPlanRepository
    {
        public List<WORKPLAN> Get()
        {
            using (GSEntities entities = new GSEntities())
            {
                return entities.WORKPLAN.Where(x=>x.Estado).ToList();
            }
        }

        public WORKPLAN Get(int id)
        {
            using (GSEntities entities = new GSEntities())
            {
                return entities.WORKPLAN.Find(id);
            }
        }

        public void Add(WORKPLAN workplan)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    entities.WORKPLAN.Add(workplan);
                    entities.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Edit(WORKPLAN workplan)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    var workplanInDb = entities.WORKPLAN.Find(workplan.WorkPlanId);
                    if (workplanInDb != null)
                    {
                        workplanInDb.Name = workplan.Name;
                        workplanInDb.Objective = workplan.Objective;
                        workplanInDb.FechaInicio = workplan.FechaInicio;
                        workplanInDb.FechaFin = workplan.FechaFin;
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
                    var workplan = entities.WORKPLAN.Find(id);
                    if (workplan != null)
                    {
                        workplan.Estado = false;
                    }

                    entities.SaveChanges();
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
