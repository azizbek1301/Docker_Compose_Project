using Car.Application.DTOs;
using Car.Domain.Models;

namespace Car.Application.Services
{
    public interface ICarService
    {
        public ValueTask<string> CreateCarAsync(CarDto carDto);
        public ValueTask<List<Cars>> GetAllAsync();
        public ValueTask<Cars> GetByIdAsync(int id);
        public ValueTask<string> DeleteByIdAsync(int id);
        public ValueTask<string> UpdateCarAsync(int id, CarDto carDto);
    }
}
