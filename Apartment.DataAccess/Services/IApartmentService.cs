using Apartment.Application.DTOs;
using Apartment.Domain.Models;

namespace Apartment.Application.Services
{
    public interface IApartmentService
    {
        public ValueTask<bool> CreateApartmentAsync(ApartmentDtos apartmentDtos);
        public ValueTask<List<ApartmentModels>> GetAllAsync();
        public ValueTask<ApartmentModels> GetByIdAsync(int id);
        public ValueTask<string> DeleteByIdAsync(int id);
        public ValueTask<string> UpdateApartmentAsync(int id, ApartmentDtos apartmentDtos);
    }
}
