using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSports.DL.DALI
{
    public interface ICoachRepository
    {
        List<COACH> Get();
        COACH Get(int id);
        void Add(COACH macrociclo);
        void Edit(COACH macrociclo);
        void Delete(int id);
    }
}
