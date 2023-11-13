using System.ComponentModel.DataAnnotations;

namespace DongVanThanh.Models
{
    public class OrderModel
    {
        [Key]
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemQty { get; set; }

        public string OrderDelivery { get; set; }

        public string OrderAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
