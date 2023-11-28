using School.Domain.Models;

namespace School.Application.Services
{
    public interface IClassService
    {
        ValueTask CreateAsync(Class model);
        ValueTask DeleteAsync(int classId);
        ValueTask<IEnumerable<Class>> GetAllAsync();
    }
}
