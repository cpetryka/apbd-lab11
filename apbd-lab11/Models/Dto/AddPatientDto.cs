using System.ComponentModel.DataAnnotations;

namespace apbd_lab11.Models.Dto;

public class AddPatientDto
{
    [Required]
    public int IdPatient { get; set; }

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }

    [Required]
    public DateTime Birthdate { get; set; }
}