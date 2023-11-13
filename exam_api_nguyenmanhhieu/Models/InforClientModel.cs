using System;
using System.ComponentModel.DataAnnotations;

namespace exam_api_nguyenmanhhieu.Models
{
    public class InforClientModel
    {
        [Key]
        public int Client { get; set; }
        [Display(Name = "Input Name Client")]
        public string Name { get; set; }
        [Display(Name = "Input Quantity")]
        public string Quantity { get; set; }
        [Display(Name = "Delivery Time")]
        public string DeliveryTime { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "ContactPhone")]
        public int ContactPhone { get; set; }
    }
}


