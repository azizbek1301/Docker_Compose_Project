using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tourism.Application.DTOs;
using Tourism.Application.Services;

namespace TourismWeb.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TurismController : ControllerBase
    {
        private readonly ITurismService _turismService;

        public TurismController(ITurismService turismService)
        {
            _turismService = turismService;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateCarAsync(TicketDto ticketDto)
        {
            var res = await _turismService.CreateTicketAsync(ticketDto);
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var res = await _turismService.GetAllAsync();
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int id)
        {
            var res = await _turismService.GetByIdAsync(id);
            return Ok(res);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteByIdAsync(int id)
        {
            var res = await _turismService.DeleteByIdAsync(id);
            return Ok(res);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateTicketAsync(int id, TicketDto ticketDto)
        {
            var res = await _turismService.UpdateTicketAsync(id, ticketDto);
            return Ok(res);
        }
    }
}
