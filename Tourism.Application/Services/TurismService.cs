using Microsoft.EntityFrameworkCore;
using Tourism.Application.DTOs;
using Tourism.Domain.Models;
using Tourism.Infrastructure.AppDbContext;

namespace Tourism.Application.Services
{
    public class TurismService:ITurismService
    {
        private readonly ApplicationDbContext _context;
        public TurismService(ApplicationDbContext context)
        {
            _context = context;
        }

        

        public async ValueTask<string> CreateTicketAsync(TicketDto ticketDto)
        {
            try
            {
                var res = new Ticket()
                {
                    Where=ticketDto.Where,
                    WhereTo=ticketDto.WhereTo,
                    Price=ticketDto.Price,
                };
                await _context.Tickets.AddAsync(res);
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
                var res = await _context.Tickets.FirstOrDefaultAsync(x => x.TicketId == id);
                if (res != null)
                {
                    _context.Tickets.Remove(res);
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

        public async ValueTask<List<Ticket>> GetAllAsync()
        {
            try
            {
                var res = await _context.Tickets.AsNoTracking().ToListAsync();
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async ValueTask<Ticket> GetByIdAsync(int id)
        {
            try
            {
                var res = await _context.Tickets.FirstOrDefaultAsync(x => x.TicketId == id);
                return res;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ValueTask<string> UpdateTicketAsync(int id, TicketDto carDto)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<string> UpdateTurismAsync(int id, TicketDto ticketDto)
        {
            try
            {
                var res = await _context.Tickets.FirstOrDefaultAsync(x => x.TicketId == id);
                if (res != null)
                {
                    res.Where=ticketDto.Where;
                    res.WhereTo = ticketDto.WhereTo;
                    res.Price = ticketDto.Price;    
                    await _context.SaveChangesAsync();
                    return "Yangilndi";
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
