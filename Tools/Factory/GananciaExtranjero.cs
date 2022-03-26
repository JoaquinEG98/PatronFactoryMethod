using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Factory
{
    public class GananciaExtranjero : IGanancia
    {
        private decimal _porcentaje;
        private decimal _extra;

        public GananciaExtranjero(decimal porcentaje, decimal extra)
        {
            _porcentaje = porcentaje;
            _extra = extra;
        }

        public decimal Ganancia(decimal monto)
        {
            return (monto * _porcentaje) + _extra; 
        }
    }
}
