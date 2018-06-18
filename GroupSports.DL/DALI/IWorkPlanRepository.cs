using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSports.DL.DALI
{
    public interface IWorkPlanRepository
    {
        List<WORKPLAN> Get();
        WORKPLAN Get(int id);
        void Add(WORKPLAN workplan);
        void Edit(WORKPLAN workplan);
        void Delete(int id);
    }
}
