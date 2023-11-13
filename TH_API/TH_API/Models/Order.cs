using System.ComponentModel.DataAnnotations;

namespace TH_API.Models;

public class Order

{
    [Key]
    public int Id { get; set; }

    public string ItemName { get; set; }
    public double quantity { get; set; }
    public string DeliveryTime { get; set; }
    public string Address { get; set; }
    public string Contact { get; set; }
    public int phone { get; set; }
}