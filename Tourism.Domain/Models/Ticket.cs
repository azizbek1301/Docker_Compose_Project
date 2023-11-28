using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tourism.Domain.Models
{
    public class Ticket
    {
        [Key]
        [JsonIgnore]
        public int TicketId { get; set; }
        public string Where { get; set; }
        public string WhereTo { get; set; }
        public decimal Price { get; set; }
    }
}
