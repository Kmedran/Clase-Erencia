using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Erencia.Clase_Base
{
    internal class CDS_Consola
    {
        public string Marca { get; set; }
        public int AnioLanzamiento { get; set; }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Algo Nuevo Marca: {Marca}, Año Lanzamiento: {AnioLanzamiento}");
        }
    }
}
