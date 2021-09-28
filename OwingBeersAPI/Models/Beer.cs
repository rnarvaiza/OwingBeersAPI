using System;
using System.Collections.Generic;

#nullable disable

namespace OwingBeersAPI.Models
{
    public partial class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UntappdLink { get; set; }

        public List<User> Users { get; set; }
    }
}
