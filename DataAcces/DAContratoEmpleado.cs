using AsapEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class DAContratoEmpleado
    {
        public static List<Contrato_Empleado> Listado()
        {
            List<Contrato_Empleado> listado = new List<Contrato_Empleado>();
            using (ASAP6Entities data = new ASAP6Entities())
            {
                listado = data.Contrato_Empleado.ToList();
            }
            return listado;
        }

    }
}
