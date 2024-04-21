using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.ClaseHija
{
    internal class JuegoAventura : VideoJuego
    {
        public bool Mundo_abierto { get; set; }
        public void MostrarInformacion_JuegoAventura()
        {
            MostrarInformacion();
            Console.WriteLine($"El juego es mundo abierto: {Mundo_abierto}");
        }

    }
}
