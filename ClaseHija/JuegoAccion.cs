using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.ClaseHija
{
    internal class JuegoAccion : VideoJuego
    {
        public bool Esparamenores { get; set; }
        public void MostrarInformacion_Juegoaccion()
        {
            MostrarInformacion();
            Console.WriteLine($"Es para menores: {Esparamenores}");
        }
    }
}
