using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces;
using AsapEntities;

namespace BusLogic
{
    public class BLContrato_Empleado
    {
        public static List<Contrato_Empleado> Listado()
        {
            return DAContratoEmpleado.Listado();

        }



    }
}
