using apbd_lab11.Models.Dto;
using apbd_lab11.Services;
using Microsoft.AspNetCore.Mvc;

namespace apbd_lab11.Controllers;

public class PrescriptionController : ControllerBase
{
    private readonly IPrescriptionService _prescriptionService;

    public PrescriptionController(IPrescriptionService prescriptionService)
    {
        _prescriptionService = prescriptionService;
    }

    [HttpPost]
    [Route("AddPrescription")]
    public async Task<IActionResult> AddPrescription([FromBody] AddPrescriptionDto addPrescriptionDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _prescriptionService.AddPrescription(addPrescriptionDto);
        return result;
    }
}