using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Verduras
{
    [Key]
    public int VerduraId { get; set; }

    public string? Nombre { get; set; }


    [ForeignKey("VerduraId")]
    public virtual List<DetalleVerduras> Detalles { get; set; } = new List<DetalleVerduras>();

    public int Cantidad { get; set; }
}
public class DetalleVerduras
{

    [Key]
    public int id { get; set; }

    public int VerduraId { get; set; }

    [Required(ErrorMessage = "Debe selecionar el Id de una Vitamina")]
    public int VitaminaId { get; set; }

    public string? Nombre { get; set; }

    [Range(minimum: 0.000001, maximum: 100000000, ErrorMessage = "La Cantidad es Obligatoria")]
    public int Cantidad { get; set; }

}