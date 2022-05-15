using System;
using System.Collections.Generic;

#nullable disable

namespace EFWinApp.Models
{
    public partial class User
    {
        public string Account { get; set; }
        public string Pass { get; set; }
        public string Name { get; set; }
        public bool? Gender { get; set; }
        public string Address { get; set; }
        public DateTime? Dateofbirth { get; set; }
    }
}
