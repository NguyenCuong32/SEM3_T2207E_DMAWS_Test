using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Data
{
    public class OrderModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string ItemCode { get; set; } = "";
        public string ItemName { get; set; } = "";
        public string ItemQty { get; set; } = "";
        public string OrderDelivery { get; set; } = "";
        public string OrderAddress { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
    }
}
