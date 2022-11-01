using System.ComponentModel.DataAnnotations;

public class Verduras
{
    [Key]
    public int VerduraId { get; set; }

    public string? Nombre { get; set; }
}