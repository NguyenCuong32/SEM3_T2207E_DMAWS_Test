using System.ComponentModel.DataAnnotations;

namespace API1.Model
{
    public class Order
    {
        [Key]
        public int ItemCode { get; set; }

        public string ItemName { get; set; } = string.Empty;

        public string ItemQty { get; set; } = string.Empty;

        public string OrderDelivery { get; set; } = string.Empty;

        public string OrderAddress { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;
    }
}
