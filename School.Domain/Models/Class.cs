using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace School.Domain.Models
{
    public class Class
    {
        [Key]
        [JsonIgnore]
        public int ClassId { get; set; }
        public string ClassName { get; set; } = default!;
        [ForeignKey(nameof(ClassTeacher))]
        public int TeacherId { get; set; } = default!;
        public Teacher ClassTeacher { get; set; } = default!;
    }
}
