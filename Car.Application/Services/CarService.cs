using Car.Application.DTOs;
using Car.Domain.Models;
using Car.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace Car.Application.Services
{
    public class CarService : ICarService
    {
        private readonly ApplicationDbContext _context;

        public CarService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask<string> CreateCarAsync(CarDto carDto)
        {
            try
            {
                var res = new Cars()
                {
                    Name = carDto.Name,
                    Model=carDto.Model,
                    Year = carDto.Year,
                };
                await _context.Cars.AddAsync(res);
                await _context.SaveChangesAsync();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async ValueTask<string> DeleteByIdAsync(int id)
        {
            try
            {
                var res = await _context.Cars.FirstOrDefaultAsync(x => x.Id == id);
                if (res != null)
                {
                    _context.Cars.Remove(res);
                    await _context.SaveChangesAsync();
                    return "Deleted";
                }
                else
                {
                    return "Not found Apartment";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async ValueTask<List<Cars>> GetAllAsync()
        {
            try
            {
                var res = await _context.Cars.AsNoTracking().ToListAsync();
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async ValueTask<Cars> GetByIdAsync(int id)
        {
            try
            {
                var res = await _context.Cars.FirstOrDefaultAsync(x => x.Id == id);
                return res;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async ValueTask<string> UpdateCarAsync(int id, CarDto carDto)
        {
            try
            {
                var res = await _context.Cars.FirstOrDefaultAsync(x => x.Id == id);
                if (res != null)
                {
                    res.Name = carDto.Name;
                    res.Model = carDto.Model;
                    res.Year = carDto.Year;
                    await _context.SaveChangesAsync();
                    return "YAngilndi";
                }
                else
                {
                    return "Topilmadi";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
