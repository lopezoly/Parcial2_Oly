using System.ComponentModel.DataAnnotations;

public class Vitaminas
{
    [Key]
    public int VitaminaId { get; set; }

    public string? Nombre { get; set; }

    public double Cantidad { get; set; }
    
}
