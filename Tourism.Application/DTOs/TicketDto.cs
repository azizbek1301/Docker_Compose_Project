using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourism.Application.DTOs
{
    public class TicketDto
    {
        public string Where { get; set; }
        public string WhereTo { get; set; }
        public decimal Price { get; set; }
    }
}
