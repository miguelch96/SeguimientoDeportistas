using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupSports.BL.BC;
using GroupSports.DL.Actors;

namespace GroupSportsWeb.ViewModels
{
    public class ListUsersViewModel
    {
        UserService userService = new UserService();
        public List<User> listaUsuarios = new List<User>();

        public void findAll()
        {
            listaUsuarios = userService.findAll();

        }

    }
}