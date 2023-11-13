using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Class
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string ClassName { get; set; } = string.Empty;
    }
}
