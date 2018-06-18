using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL;
using GroupSports.DL.DALI;

namespace GroupSports.BL.BC
{
    public class WorkPlanService : IWorkPlanService
    {
        public IWorkPlanRepository WorkPlanRepository { get; set; } = new WorkplanRepository();

        public List<WORKPLAN> Get()
        {
            try
            {
                return WorkPlanRepository.Get();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public WORKPLAN Get(int id)
        {
            try
            {
                return WorkPlanRepository.Get(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Add(WORKPLAN workplan)
        {
            try
            {
                WorkPlanRepository.Add(workplan);
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
                WorkPlanRepository.Edit(workplan);
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
                WorkPlanRepository.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
