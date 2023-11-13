using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMAWS_TEST_API.Models
{
    public class Order
    {
        [Key]
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public int ItemQty{ get; set; }
        public string OrderDelivery { get; set; }
        public string OrderAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
