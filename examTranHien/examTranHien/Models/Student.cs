using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace examTranHien.Models
{
	public class Student
	{
		[Required]
		public int Id { get; set; }
		[Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int ClassId { get; set; }

       // [ForeignKey("Class")]
        [NotMapped]
		public virtual Class Class { get; set; }

    }
}
