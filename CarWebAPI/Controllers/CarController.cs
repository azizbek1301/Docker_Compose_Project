using Car.Application.DTOs;
using Car.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateCarAsync(CarDto carDto)
        {
            var res = await _carService.CreateCarAsync(carDto);
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var res = await _carService.GetAllAsync();
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int id)
        {
            var res = await _carService.GetByIdAsync(id);
            return Ok(res);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteByIdAsync(int id)
        {
            var res = await _carService.DeleteByIdAsync(id);
            return Ok(res);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateCarAsync(int id, CarDto carDto)
        {
            var res = await _carService.UpdateCarAsync(id, carDto);
            return Ok(res);
        }
    }
}
