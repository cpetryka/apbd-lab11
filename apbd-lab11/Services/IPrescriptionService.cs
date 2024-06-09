using apbd_lab11.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace apbd_lab11.Services;

public interface IPrescriptionService
{
    Task<IActionResult> AddPrescription(AddPrescriptionDto addPrescriptionDto);
}