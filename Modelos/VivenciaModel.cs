namespace Tarea9.Modelos;

public class VivenciaModel
{
    public string Titulo { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string? Imagen { get; set; }
}
