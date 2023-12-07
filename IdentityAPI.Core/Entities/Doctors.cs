using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityAPI.Core.Entities
{
    public class Doctors
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ProfileImagePath { get; set; }
        public int NumberOfProperties { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public ICollection<Appointments> Appointments { get; set; }
    }
}
