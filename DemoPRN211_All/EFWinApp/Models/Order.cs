using System;
using System.Collections.Generic;

#nullable disable

namespace EFWinApp.Models
{
    public partial class Order
    {
        public decimal OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
