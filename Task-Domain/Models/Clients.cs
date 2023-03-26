using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Domain.Models
{
    public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
