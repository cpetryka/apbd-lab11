using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apbd_lab11.Models;

[Table("medicaments")]
public class Medicament
{
    [Key]
    public int IdMedicament { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    [MaxLength(100)]
    public string Description { get; set; }
    [MaxLength(100)]
    public string Type { get; set; }

    public ICollection<PrescriptionMedication> PrescriptionMedications { get; set; } =
        new HashSet<PrescriptionMedication>();
}