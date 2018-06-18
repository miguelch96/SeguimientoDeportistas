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
        List<MACROCICLO> Get();
        MACROCICLO Get(int id);
        List<MACROCICLO> GetByWorkplan(int workplanid);
        void Add(MACROCICLO macrociclo);
        void Edit(MACROCICLO macrociclo);
        void Delete(int id);
    }
}
