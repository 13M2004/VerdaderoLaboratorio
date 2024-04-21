using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.ClaseHija
{
    internal class JuegoDeportes : VideoJuego
    {
        public string Equipos { get; set; }
        public void MostrarInformacion_Juegodeportes()
        {
            MostrarInformacion();
            Console.WriteLine($"Equipos con los que puedes jugar:");
            Console.WriteLine(Equipos);
        }
    }
}

