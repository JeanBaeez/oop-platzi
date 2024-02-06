namespace real_platzi_2024.poo;

public class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;

    public SuperPoder()
    {
        Nivel = NivelPoder.NivelUno;
    }
}


public enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}