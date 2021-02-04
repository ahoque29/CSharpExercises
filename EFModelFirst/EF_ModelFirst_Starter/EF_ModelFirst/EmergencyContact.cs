using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst
{
	public partial class EmergencyContact
	{
		public EmergencyContact()
		{
			Customers = new HashSet<Customer>();
		}

		public string EmergencyContactId { get; set; }
		public string CustomerId { get; set; }
		public string ContactName { get; set; }
		public string City { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }

		public virtual ICollection<Customer> Customers { get; set; }
	}
}
