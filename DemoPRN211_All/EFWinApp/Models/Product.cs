using System;
using System.Collections.Generic;

#nullable disable

namespace EFWinApp.Models
{
    public partial class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public float? Price { get; set; }
        public string Image { get; set; }
    }
}
