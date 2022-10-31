using System.ComponentModel.DataAnnotations;

public class VerduraDetalle{
    
    [Key]
    public int Id { get; set; }
    [Required]
    public int VerduraId { get; set; }
    [Required]
    public int VitaminaId { get; set; }
    [Required]
    public int Cantidad { get; set; }

}