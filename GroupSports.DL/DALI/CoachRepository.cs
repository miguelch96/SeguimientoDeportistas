using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSports.DL.DALI
{
    public class CoachRepository : ICoachRepository
    {
        public List<COACH> Get()
        {
            using (GSEntities entities = new GSEntities())
            {
                return entities.COACH.ToList();
            }
        }

        public COACH Get(int id)
        {
            using (GSEntities entities = new GSEntities())
            {
                return entities.COACH.Find(id);
            }
        }

        public void Add(COACH coach)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    entities.COACH.Add(coach);
                    entities.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Edit(COACH coach)
        {
            try
            {
                using (GSEntities entities = new GSEntities())
                {
                    var coachInDb = entities.COACH.Find(coach.CoachId);
                    if (coachInDb != null)
                    {
                        //coachInDb.UserId = macrociclo.Name;
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
                    var coach = entities.COACH.Find(id);
                    if (coach != null)
                    {
                        coach.USUARIO.Estado = false;
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
