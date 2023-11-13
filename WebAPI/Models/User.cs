using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class User
    {

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public virtual Class? Class { get; set; }
    }
}
