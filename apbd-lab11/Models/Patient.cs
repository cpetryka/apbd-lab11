using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apbd_lab11.Models;

[Table("patients")]
public class Patient
{
    [Key]
    public int IdPatient { get; set; }
    [MaxLength(100)]
    public string FirstName { get; set; }
    [MaxLength(100)]
    public string LastName { get; set; }
    public DateTime Birthdate { get; set; }

    public ICollection<Prescription> Prescriptions { get; set; } = new HashSet<Prescription>();
}