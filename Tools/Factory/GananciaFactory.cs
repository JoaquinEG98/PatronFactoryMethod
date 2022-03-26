using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Factory
{
    public abstract class GananciaFactory
    {
        public abstract IGanancia GetGanancia();
    }
}
