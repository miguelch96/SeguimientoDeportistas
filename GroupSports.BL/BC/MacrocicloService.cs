﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupSports.DL;
using GroupSports.DL.DALI;

namespace GroupSports.BL.BC
{
    public class MacrocicloService : IMacrocicloService
    {
        public IMacrocicloRepository MacrocicloRepository { get; set; } = new MacrocicloRepository();

        public List<MACROCICLO> Get(int? workplanid)
        {
            try
            {
                return MacrocicloRepository.Get(workplanid);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public MACROCICLO Find(int id)
        {
            try
            {
                return MacrocicloRepository.Find(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Add(MACROCICLO macrociclo)
        {
            try
            {
                MacrocicloRepository.Add(macrociclo);
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
                MacrocicloRepository.Edit(macrociclo);
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
                MacrocicloRepository.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
