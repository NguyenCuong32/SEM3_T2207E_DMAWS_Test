using System.ComponentModel.DataAnnotations;

namespace DMAWS.Data;

public class OrderTbl
{
    [Key] public int ItemCode { get; set; }
    public string ItemName { get; set; }
    public int ItemQty { get; set; }
    public string OrderDelivery { get; set; }
    public string OrderAddress { get; set; }
    [Phone] public string PhoneNumber { get; set; }
}