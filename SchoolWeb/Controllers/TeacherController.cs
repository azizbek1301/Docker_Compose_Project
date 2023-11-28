using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Application.Services;
using School.Domain.Models;

namespace SchoolWeb.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _repo;

        public TeacherController(ITeacherService repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async ValueTask<IActionResult> PostAsync(Teacher teacher)
        {
            await _repo.CreateAsync(teacher);

            return Ok();
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int teacherId)
        {
            await _repo.DeleteAsync(teacherId);

            return Ok();
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<Teacher> teachers = await _repo.GetAllAsync();

            return Ok(teachers);
        }
    }
}
