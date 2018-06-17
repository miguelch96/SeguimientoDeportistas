//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using GroupSports.BL.BC;
//using GroupSports.DL.DM;

//namespace GroupSportsWeb.ViewModels
//{
//    public class EditParameterViewModel
//    {
//        public int id { get; set; }
//        public string parameternName { get; set; }
//        public List<parameter> lstparametros = new List<parameter>();
//        group_sportsEntities context = new group_sportsEntities();
//        public void listar()
//        {
//            foreach (var item in context.parameter.ToList())
//            {
//                parameter parametro = new parameter();
//                parametro.id = item.id;
//                parametro.parameterName = item.parameterName;
//                lstparametros.Add(parametro);
//            }

//        }
//        public void findbyId(int id)
//        {
//           parameter parametro = context.parameter.FirstOrDefault(x => x.id == id);
//            id = parametro.id;
//            parameternName = parametro.parameterName;
//            this.lstparametros = context.parameter.ToList();
//        }
//    }
//}