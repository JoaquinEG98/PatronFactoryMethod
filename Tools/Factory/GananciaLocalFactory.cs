using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Factory
{
    public class GananciaLocalFactory : GananciaFactory
    {
        private decimal _porcentaje;

        public GananciaLocalFactory(decimal porcentaje)
        {
            _porcentaje = porcentaje;
        }

        public override IGanancia GetGanancia()
        {
            return new GananciaLocal(_porcentaje);
        }
    }
}
