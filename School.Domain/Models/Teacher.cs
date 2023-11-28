using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace School.Domain.Models
{
    public class Teacher
    {
        [Key]
        [JsonIgnore]
        public int TeacherId { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
    }
}
