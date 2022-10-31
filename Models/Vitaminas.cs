using System.ComponentModel.DataAnnotations;
public class Vitaminas{
    [Key]
    public int VitaminaId { get; set; }

    [Required]
    public string? Nombre { get; set; }

}