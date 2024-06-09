using System.ComponentModel.DataAnnotations;

namespace apbd_lab11.Models.Dto;

public class AddMedicamentDto
{
    [Required]
    public int IdMedicament { get; set; }

    [Required]
    public int Dose { get; set; }

    [MaxLength(100)]
    public string Details { get; set; }
}