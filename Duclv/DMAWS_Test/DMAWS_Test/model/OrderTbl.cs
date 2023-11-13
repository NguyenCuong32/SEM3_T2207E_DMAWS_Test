using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DMAWS_Test.model
{
    public class OrderTbl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemCode { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string ItemName { get; set; }

        [Column(TypeName = "int")]
        public int ItemQty { get; set; }

        [Column(TypeName = "nvarchar(512)")]
        public string OrderDelivery { get; set; }

        [Column(TypeName = "nvarchar(512)")]
        public string OrderAddress { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string PhoneNumber { get; set; }
    }
}
