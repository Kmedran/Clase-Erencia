using Clase_Erencia.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Erencia.Clase_Hija
{
    internal class Xbox : CDS_Consola
    {
        public bool GamePass { get; set; }

        public string MostrarDetallesXbox()
        {
            MostrarDetalles();
            return $"Tiene Game Pass:{GamePass}";
        }
    }
}
