using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Verduras{
    [Key]
    public int VerduraId { get; set; }
    [Required]
    public DateTime FechaCreacion { get; set; }

    [Required]
    public string? Nombre { get; set; }

    [Required]
    public string?  Observaciones { get; set; }

    [ForeignKey("VerduraId")]
    public List<VerduraDetalle> Detalle {get; set;} = new List<VerduraDetalle>();
    

}