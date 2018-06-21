using AsapEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class DARol
    {
        public static List<Rol> Listado()
        {
            List<Rol> listado = new List<Rol>();
            using (ASAP6Entities data = new ASAP6Entities())
            {
                listado = data.Rol.ToList();
            }
            return listado;
        }
    }
}
