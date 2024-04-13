using Clase_Erencia.Clase_Base;
using Clase_Erencia.Clase_Hija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clase_Erencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Nintendo sw = new Nintendo();
            sw.EsPortatil = true;
            sw.AnioLanzamiento = 2017;
            sw.Marca = "Nintendo Swicht";
            sw.MostrarDetallesNintendo();

            Play_Station ps = new Play_Station();
            ps.ModeContorlador = "Dual Sent";
            ps.AnioLanzamiento = 2016;
            ps.Marca = "Play Station 4";
            ps.MostrarDetallesPS();

            Xbox xb = new Xbox();
            xb.GamePass = true;
            xb.AnioLanzamiento = 2022;
            xb.Marca = "Xbox Series X";
            xb.MostrarDetallesXbox();
        }
    }
}
