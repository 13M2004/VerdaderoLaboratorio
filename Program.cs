using LaboratorioProgra1.ClaseHija;
using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;

static void EjemploPolimorfismo()
{
    Animal[] animales = new Animal[3];
    animales[0] = new Tortuga();
    animales[1] = new Gato();
    animales[2] = new Perro();
    foreach (Animal animal in animales)
    {
        animal.HacerSonido();
    }
}   

static void Laboratorio()
{
    VideoJuego VideoJuego = new VideoJuego();
    VideoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
    VideoJuego.Desarrolladora = "Nintendo";
    VideoJuego.Calificacion = 50;
    VideoJuego.AnioLanzamiento = 2017;
    VideoJuego.MostrarInformacion();
}

static void JuegoAAccion()
{
    JuegoAccion AccionJuegoo = new JuegoAccion();
    AccionJuegoo.Titulo = "Free Fire";
    AccionJuegoo.Desarrolladora = "Garena";
    AccionJuegoo.Calificacion = 9;
    AccionJuegoo.AnioLanzamiento = 2017;

    AccionJuegoo.Esparamenores = true;

    AccionJuegoo.MostrarInformacion_Juegoaccion();
}

static void DDeportesJuego()
{
    JuegoDeportes Juegodeportes = new JuegoDeportes();
    Juegodeportes.Titulo = "FIFA";
    Juegodeportes.Desarrolladora = "Football Association";
    Juegodeportes.Calificacion = 10;
    Juegodeportes.AnioLanzamiento = 2010;
    Juegodeportes.Equipos = "Real Madrid.\nBarcelona.\nAtletico de Madrid.";

    Juegodeportes.MostrarInformacion_Juegodeportes();
}

static void JuegosAventura()
{
    JuegoAventura JuegoAventuraa = new JuegoAventura();
    JuegoAventuraa.Titulo = "JUMANJI";
    JuegoAventuraa.Desarrolladora = "Chirs Van";
    JuegoAventuraa.Calificacion = 3;
    JuegoAventuraa.AnioLanzamiento = 1995;
    JuegoAventuraa.Mundo_abierto = true;

    JuegoAventuraa.MostrarInformacion_JuegoAventura();
}


JuegoAAccion();
Console.WriteLine("");
DDeportesJuego();
Console.WriteLine("");
JuegosAventura();

Console.ReadKey();
//Laboratorio();
//VideoJuego.listaDeJuegos();





Console.WriteLine();



