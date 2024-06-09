namespace apbd_lab11.Models.Dto;

public class GetPrescriptionWithDoctorDto
{
    public int IdPrescription { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public List<GetMedicamentDto> Medicaments { get; set; }
    public GetDoctorDto Doctor { get; set; }
}