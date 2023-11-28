using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Car.Domain.Models
{
    public class Cars
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        public string Model {  get; set; }
        public string Name { get; set; }    
        public int Year {  get; set; }
    }
}
