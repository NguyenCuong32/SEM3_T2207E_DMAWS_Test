using System.ComponentModel.DataAnnotations;

namespace Order_API.Models;

public class Order
{
    [Key]
    public int Id { get; set; }
    public string ItemCode { get; set; }
    public string ItemName { get; set; }
    public string Quantity { get; set; }
    public string OrderDelivery { get; set; }
    public string OrderAddress { get; set; }
    public int PhoneNumber { get; set; }
}