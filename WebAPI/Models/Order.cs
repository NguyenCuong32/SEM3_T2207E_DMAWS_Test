namespace WebAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ItemCode { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;
        public int ItemQty { get; set; }
        public DateTime OrderDelivery { get; set; }
        public string OrderAddress { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
