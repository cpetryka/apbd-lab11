using apbd_lab11.Models.Dto;

namespace apbd_lab11.Services;

public interface IPatientService
{
    Task<GetPatientWithPrescriptionsDto?> GetPatientData(int idPatient);
}