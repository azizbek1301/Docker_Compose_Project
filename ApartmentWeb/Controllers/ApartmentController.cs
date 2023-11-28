using Apartment.Application.DTOs;
using Apartment.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentWeb.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private readonly IApartmentService _apartmentService;
        public ApartmentController(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateApartmentAsync(ApartmentDtos apartmentDto)
        {
            var res = await _apartmentService.CreateApartmentAsync(apartmentDto);
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var res = await _apartmentService.GetAllAsync();
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int id)
        {
            var res = await _apartmentService.GetByIdAsync(id);
            return Ok(res);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteByIdAsync(int id)
        {
            var res = await _apartmentService.DeleteByIdAsync(id);
            return Ok(res);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateApartmentAsync(int id, ApartmentDtos apartmentDto)
        {
            var res = await _apartmentService.UpdateApartmentAsync(id, apartmentDto);
            return Ok(res);
        }
    }
}
