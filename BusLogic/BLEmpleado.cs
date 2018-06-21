using AsapEntities;
using DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLogic
{
    public class BLEmpleado
    {
        public static List<Empleado> Listado()
        {
            return DAEmpleado.Listado();

        }

    }
}
