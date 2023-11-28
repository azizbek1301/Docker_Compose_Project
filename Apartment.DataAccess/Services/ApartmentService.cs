using Apartment.Application.DTOs;
using Apartment.Domain.Models;
using Apartment.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace Apartment.Application.Services
{
    public class ApartmentService : IApartmentService
    {
        private readonly ApplicationDbContext _dbContext;
        public ApartmentService( ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async ValueTask<bool> CreateApartmentAsync(ApartmentDtos apartmentDtos)
        {
            try
            {
                var res = new ApartmentModels()
                {
                    Name = apartmentDtos.Name,
                    Number = apartmentDtos.Number,
                    Floor = apartmentDtos.Floor,
                    Room = apartmentDtos.Room,
                    Location = apartmentDtos.Location,
                };
                await _dbContext.Apartments.AddAsync(res);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async ValueTask<string> DeleteByIdAsync(int id)
        {
            try
            {
                var res = await _dbContext.Apartments.FirstOrDefaultAsync(x => x.Id == id);
                if (res != null)
                {
                    _dbContext.Apartments.Remove(res);
                    await _dbContext.SaveChangesAsync();
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

        public async ValueTask<List<ApartmentModels>> GetAllAsync()
        {
            try
            {
                var res = await _dbContext.Apartments.AsNoTracking().ToListAsync();
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async ValueTask<ApartmentModels> GetByIdAsync(int id)
        {
            try
            {
                var res = await _dbContext.Apartments.FirstOrDefaultAsync(x => x.Id == id);
                return res;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async ValueTask<string> UpdateApartmentAsync(int id, ApartmentDtos apartmentDtos)
        {
            try
            {
                var res = await _dbContext.Apartments.FirstOrDefaultAsync(x => x.Id == id);
                if (res != null)
                {
                    res.Name = apartmentDtos.Name;
                    res.Number = apartmentDtos.Number;
                    res.Room = apartmentDtos.Room;
                    res.Floor = apartmentDtos.Floor;
                    res.Location = apartmentDtos.Location;
                    await _dbContext.SaveChangesAsync();
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
