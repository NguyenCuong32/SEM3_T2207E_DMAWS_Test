namespace phamngocdungFinalTest.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int ItemQty { get; set; }
        public string OrderDelivery { get; set; }
        public string OrderAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
