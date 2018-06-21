using AsapEntities;
using DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLogic
{
    public class BLRol
    {
        public static List<Rol> Listado()
        {
            return DARol.Listado();

        }

    }
}
