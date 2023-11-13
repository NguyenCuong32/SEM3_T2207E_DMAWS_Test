using System;
using System.ComponentModel.DataAnnotations;

namespace examTranHien.Models
{
	public class Class
	{
		[Key]
		[Required]

		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
	}
}

