using Clase_Erencia.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Erencia.Clase_Hija
{
    internal class Play_Station : CDS_Consola
    {
        public string ModeContorlador { get; set; }

        public string MostrarDetallesPS()
        {
            MostrarDetalles();
            return $"Modelo de Controlador:{ModeContorlador}";
        }
    }
}
