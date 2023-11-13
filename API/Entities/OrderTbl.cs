using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("OrderSystem")]
        public class Product
        {
            [Key]
            public int ItemCode { get; set; }

            [Required]
            [StringLength(255)]
            public string ItemName { get; set; }


            [Required]
            public double ItemQty { get; set; }

            [StringLength(150)]
            public string OrderDelivery { get; set; }

            [StringLength(255)]
            public string OrderAddress { get; set; }

            [StringLength(255)]
            public string PhoneNumber { get; set; }
        }
}
