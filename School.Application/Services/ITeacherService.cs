using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application.Services
{
    public interface ITeacherService
    {
        ValueTask CreateAsync(Teacher teacher);
        ValueTask DeleteAsync(int teacherId);
        ValueTask<IEnumerable<Teacher>> GetAllAsync();
    }
}
