using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Application.Services;
using School.Domain.Models;

namespace SchoolWeb.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _repo;

        public ClassController(IClassService repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async ValueTask<IActionResult> PostAsync(Class @class)
        {
            await _repo.CreateAsync(@class);

            return Ok();
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int classId)
        {
            await _repo.DeleteAsync(classId);

            return Ok();
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<Class> classes = await _repo.GetAllAsync();

            return Ok(classes);
        }
    }
}
