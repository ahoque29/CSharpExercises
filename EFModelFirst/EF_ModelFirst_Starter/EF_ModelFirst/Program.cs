using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF_ModelFirst
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new SouthwindContext())
			{
				// Create (run it once)
				Console.WriteLine("Creating some customers");
				//db.Add(new Customer() { CustomerId = "MART", City = "London", ContactName = "Martin", PostalCode = "SE1", Country = "UK" });
				//db.Add(new Customer() { CustomerId = "CATH", City = "Birmingham", ContactName = "Cathy", PostalCode = "AB1 4DD", Country = "UK" });
				//db.Add(new Customer() { CustomerId = "SIGM", City = "Pribor", ContactName = "Sigmund", PostalCode = "742 58", Country = "Austria" });
				//db.Add(new Customer() { CustomerId = "ASHI", City = "MiltonKeynes", ContactName = "Ashib", PostalCode = "MK2 3LS", Country = "UK" });

				//db.SaveChanges();

				//// Read
				//Console.WriteLine("Querying for a customer and order");
				//var orderQuery = db.Orders;
				//var customerQuery = db.Customers
				//	.OrderBy(c => c.ContactName);

				//// get the first customer
				//var customer = customerQuery.First();
				//Console.WriteLine($"First Customer is {customer.ContactName} who lives in {customer.City}");

				////get the last customer
				//var lastCustomer = customerQuery.Last();
				//Console.WriteLine($"Last Customer is {lastCustomer.ContactName} who lives in {lastCustomer.City}");

				////update
				//customer.City = "Ottawa";
				//customer.Country = "Canada";
				//db.SaveChanges();

				////create and update
				//var martin = db.Customers.Find("MART");
				//martin.Orders.Add(new Order() { CustomerId = "MART", OrderDate = DateTime.Now, ShipCountry = "Brazil" });
				//martin.Orders.Add(new Order() { CustomerId = "MART", OrderDate = DateTime.Now, ShipCountry = "France" });

				// add emergency contact
				var ashib = db.Customers.Find("ASHI");
				ashib.EmergencyContacts.Add(new EmergencyContact { EmergencyContactId = "ASHI", City = "Milton Keynes", ContactName = "Amin", Country = "UK" });

				db.SaveChanges();

				//////create new order
				////db.Add(new Order() { CustomerId = "SIGM", OrderDate = new DateTime(2020,02,21), ShipCountry = "UK" });

				//db.SaveChanges();

				////Query
				//foreach (var c in customerQuery.Include(c => c.Orders))
				//{
				//	Console.WriteLine($"{c.ContactName} lives in {c.City}");
				//	if (c.Orders.Count > 0)
				//	{
				//		foreach (var order in c.Orders)
				//		{
				//			Console.WriteLine($"\tOrder {order.OrderId} by {order.Customer.ContactName} made on {order.OrderDate.Value.Date}");
				//		}
				//	}
				//}
				//var customers = customerQuery.Include(c => c.Orders).ToArray();

				//// delete
				//Console.WriteLine($"Before deletion there are {db.Customers.Count()} customers and {db.Orders.Count()} orders.");
				//// delete all customers
				//Console.WriteLine("Deleting all the customers");
				//db.RemoveRange(customerQuery);
				//// delete all orders
				//Console.WriteLine("Deleting all the orders");
				//db.RemoveRange(orderQuery);
				////saving changes
				//db.SaveChanges();
				//Console.WriteLine($"There are now {db.Customers.Count()} customers and {db.Orders.Count()} orders.");
			}
		}

    }
}
