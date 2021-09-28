using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwingBeersAPI.Requests
{
    public class UserRequest
    {
        public string Name { get; set; }
        public byte? Status { get; set; }
        public int BeerId { get; set; }
    }
}
