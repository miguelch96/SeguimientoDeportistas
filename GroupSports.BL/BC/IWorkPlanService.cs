using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL;

namespace GroupSports.BL.BC
{
    public interface IWorkPlanService
    {
        List<WORKPLAN> Get();
        WORKPLAN Get(int id);
        void Add(WORKPLAN workplan);
        void Edit(WORKPLAN workplan);
        void Delete(int id);
    }
}
