using Tourism.Application.DTOs;
using Tourism.Domain.Models;

namespace Tourism.Application.Services
{
    public interface ITurismService
    {
        public ValueTask<string> CreateTicketAsync(TicketDto ticketDto);
        public ValueTask<List<Ticket>> GetAllAsync();
        public ValueTask<Ticket> GetByIdAsync(int id);
        public ValueTask<string> DeleteByIdAsync(int id);
        public ValueTask<string> UpdateTicketAsync(int id, TicketDto carDto);
    }
}
