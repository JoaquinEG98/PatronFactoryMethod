using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Factory
{
    public class GananciaExtranjeroFactory : GananciaFactory
    {
        private decimal _porcentaje;
        private decimal _extra;

        public GananciaExtranjeroFactory(decimal porcentaje, decimal extra)
        {
            _porcentaje = porcentaje;
            _extra = extra;
        }

        public override IGanancia GetGanancia()
        {
            return new GananciaExtranjero(_porcentaje, _extra);
        }
    }
}
