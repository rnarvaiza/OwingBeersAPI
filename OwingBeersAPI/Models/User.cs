using System;
using System.Collections.Generic;

#nullable disable

namespace OwingBeersAPI.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte? Status { get; set; }

        public Beer Beer { get; set; }
        public int BeerId { get; set; }
    }
}
