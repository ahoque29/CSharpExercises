using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
            EmergencyContacts = new HashSet<EmergencyContact>();
        }

        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
   
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; }
    }
}
