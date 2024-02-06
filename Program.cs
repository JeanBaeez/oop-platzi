using real_platzi_2024.poo;

var poderVolar = new SuperPoder
{
    Nivel = NivelPoder.NivelTres,
    Nombre = "Volar",
    Descripcion = "Puede volar por los cielos"
};
var superFuerza = new SuperPoder
{
    Nivel = NivelPoder.NivelTres,
    Nombre = "Super fuerza",
    Descripcion = "Puede levantar autos"
};
var superVelocidad = new SuperPoder
{
    Nivel = NivelPoder.NivelTres,
    Nombre = "Super velocidad",
    Descripcion = "Puede correr a la velocidad de la luz"
};
var Inteligencia = new SuperPoder
{
    Nivel = NivelPoder.NivelTres,
    Nombre = "Inteligencia",
    Descripcion = "Puede resolver problemas complejos"
};
var Dinero = new SuperPoder
{
    Nivel = NivelPoder.NivelTres,
    Nombre = "Dinero",
    Descripcion = "Puede comprar lo que quiera"
};
var instintoAnimal = new SuperPoder
{
    Nivel = NivelPoder.NivelTres,
    Nombre = "Instito Animal",
    Descripcion = "Puede comunicarse con los animales"
};
var regeneracion = new SuperPoder()
{
    Descripcion = "Puede regenerar sus heridas",
    Nivel = NivelPoder.NivelTres,
    Nombre = "Regeneracion"
};
var superPoderes = new List<SuperPoder>
    {
        poderVolar,
        superFuerza,
        superVelocidad
    };

    var superPoderes2 = new List<SuperPoder>
    {
        Inteligencia,
        Dinero
    };

var superPoderes3 = new List<SuperPoder>
    {
        superFuerza,
        superVelocidad,
        instintoAnimal,
        regeneracion
    };
var superman = new SuperHeroe
{
    PuedeVolar = true,
    Nombre = "Superman",
    Ciudad = "Metropolis",
    SuperPoderes = superPoderes,   
    Id = Guid.NewGuid(),
    IdentidadSecreta = "Clark Kent"
};
var batman = new SuperHeroe
{
    PuedeVolar = false,
    Nombre = "BatMan",
    Ciudad = "Gotham",
    SuperPoderes = superPoderes2,   
    Id = Guid.NewGuid(),
    IdentidadSecreta = "Bruce Wayne"
};
superman.UsarSuperPoderes();

var wolverine = new AntiHeroe()
{
    PuedeVolar = false,
    IdentidadSecreta = "Logan",
    Nombre = "Wolverine",
    Ciudad = "New York",
    Id = Guid.NewGuid(),
    SuperPoderes = superPoderes3,
   
};
var imprimirInfo = new ImprimirInfo();



 
// Console.WriteLine(superman.UsarSuperPoderes());
// Console.WriteLine(batman.UsarSuperPoderes());
// Console.WriteLine(wolverine.UsarSuperPoderes());
// Console.WriteLine(wolverine.RealizarAccionDeAntiHeroe("Atacar"));
// Console.WriteLine(superman.SalvarElMundo());
// Console.WriteLine(batman.SalvarElMundo());
// Console.WriteLine(wolverine.SalvarElMundo());
// Console.WriteLine(superman.SalvarLaTierra());
// Console.WriteLine(batman.SalvarLaTierra());
// Console.WriteLine(wolverine.SalvarLaTierra());
//
//  
imprimirInfo.Imprimir(wolverine);
imprimirInfo.Imprimir(superman);
imprimirInfo.Imprimir(batman);
