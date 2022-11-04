using System.ComponentModel.DataAnnotations;

public class Vitaminas
{
    [Key]

    public int VitaminaId { get; set; }

    public string? Nombre { get; set; }

    [Range(1, 100000, ErrorMessage = "Rango Minimmo del prestamo es 1 - Rango Maximo es 100,000")]
    public double Cantidad { get; set; }
    
}
