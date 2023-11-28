using Microsoft.EntityFrameworkCore;
using School.Domain.Models;
using School.Infrastructure.AppDbContext;

namespace School.Application.Services
{
    public class ClassService : IClassService
    {
        private readonly ApplicationDbContext _context;

        public ClassService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask CreateAsync(Class model)
        {
            await _context.Classes.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async ValueTask DeleteAsync(int classId)
        {
            Class cl = await _context.Classes.FirstOrDefaultAsync(x => x.ClassId == classId);

            if (cl != null)
            {
                _context.Remove(cl);
                await _context.SaveChangesAsync();
            }
        }

        public async ValueTask<IEnumerable<Class>> GetAllAsync()
        {
            IEnumerable<Class> classes = await _context.Classes.ToListAsync();

            return classes;
        }
    }
}
