using GroupSports.DL.Actors;
using GroupSports.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSports.BL.BC
{
    public interface IUserService
    {
        List<User> findAll();
        //user findById(int id);
        //List<user> findByName(string name);
        //void insertUser(user user);
        //void updateUser(user user);
        //void deleteUser(int id);
        //user Login(LoginDTO loginDTO);
    }
}
