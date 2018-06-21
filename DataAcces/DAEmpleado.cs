using AsapEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class DAEmpleado
    {
        public static List<Empleado> Listado()
        {
            List<Empleado> listado = new List<Empleado>();
            using (ASAP6Entities data = new ASAP6Entities())
            {
                listado = data.Empleado.ToList();
            }
            return listado;
        }

    }
}
