using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL;

namespace GroupSports.BL.BC
{
    public interface IMacrocicloService
    {
        List<MACROCICLO> Get(int? workplanid);
        MACROCICLO Find(int id);
        void Add(MACROCICLO macrociclo);
        void Edit(MACROCICLO macrociclo);
        void Delete(int id);
    }
}
