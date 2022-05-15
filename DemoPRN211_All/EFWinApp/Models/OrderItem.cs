using System;
using System.Collections.Generic;

#nullable disable

namespace EFWinApp.Models
{
    public partial class OrderItem
    {
        public decimal OrderItemId { get; set; }
        public decimal OrderId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
