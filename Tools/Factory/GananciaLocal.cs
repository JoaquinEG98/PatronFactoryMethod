using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Factory
{
    public class GananciaLocal : IGanancia
    {
        private decimal _porcentaje;

        public GananciaLocal(decimal porcentaje)
        {
            _porcentaje = porcentaje;
        }

        public decimal Ganancia(decimal monto)
        {
            return monto * _porcentaje;
        }
    }
}
