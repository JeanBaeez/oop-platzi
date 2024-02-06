 
using System.Text;

namespace real_platzi_2024.poo;

public class SuperHeroe : Heroe , ISuperHeroe
{
    private  string _Nombre;
     

    public Guid Id { get; set; }
    

    public override string Nombre
    {
        get => _Nombre;
        set
        {
            _Nombre = value.Trim();
        }
    }

    public string IdentidadSecreta { get; set; }



    public string NombreEIdentidadSecreta
    {
        get=>  $"{Nombre} - ({IdentidadSecreta})";
    }
 
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;

    public string UsarSuperPoderes()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var poder in SuperPoderes)  
        {
            sb.AppendLine($"{NombreEIdentidadSecreta} Usando el poder {poder.Nombre}!!!");
        }

        return sb.ToString();
    }

    public SuperHeroe()
    {
        Id = Guid.NewGuid();
        SuperPoderes = new List<SuperPoder>();
        PuedeVolar = false;

    }


    public record SuperHeroesRecord(
        Guid Id,
        string Nombre,
        string? IdentidadSecreta);


    public override string SalvarElMundo()
    {
       return $"{NombreEIdentidadSecreta} Salvando el mundo";
    }

    public override string SalvarLaTierra()
    {
       // return base.SalvarLaTierra();
       return $"{NombreEIdentidadSecreta} ha salvado la tierra";
    }
}



 