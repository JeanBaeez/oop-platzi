namespace real_platzi_2024.poo;

public class ImprimirInfo
{
    public void Imprimir(ISuperHeroe superHeroe)
    {
        Console.WriteLine($"Id: {superHeroe.Id}");
        Console.WriteLine($"Nombre: {superHeroe.Nombre}");
        Console.WriteLine($"Identidad Secreta: {superHeroe.IdentidadSecreta}");
    }
    
}