namespace Tarea9.Modelos;

public class VivenciaEntry
{
    public string Titulo { get; set; } = string.Empty; // El título de la vivencia
    public string Descripcion { get; set; } = string.Empty; // La descripción o detalle de la vivencia
    public DateTime Fecha { get; set; } = DateTime.Now; // Fecha en la que ocurrió la vivencia
    public string? Imagen { get; set; } // Ruta o nombre del archivo de la imagen asociada (puede ser opcional)
}
