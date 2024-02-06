namespace real_platzi_2024.poo;

public abstract class Heroe
{
    public abstract string SalvarElMundo();
    public abstract string Nombre { get; set; }

    public virtual string SalvarLaTierra()
    {
        return $"{Nombre} ha salvado la tierra";
    }
}