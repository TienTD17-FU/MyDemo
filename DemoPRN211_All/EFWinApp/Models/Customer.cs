using System;
using System.Collections.Generic;

#nullable disable

namespace EFWinApp.Models
{
    public partial class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
