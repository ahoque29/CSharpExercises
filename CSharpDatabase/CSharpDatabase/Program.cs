using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CSharpDatabase
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new NorthwindContext())
			{
				//var orderQuery =
				//	from order in db.Orders
				//	where order.Freight > 750
				//	select order;

				//foreach (var order in orderQuery)
				//{
				//	Console.WriteLine($"{order.CustomerId} paid {order.Freight} for shipping to {order.ShipCity}");
				//}

				//var orderQuerywithCust = from order in db.Orders.Include(o => o.Customer)
				//						 where order.Freight > 750
				//						 select order;
				//foreach (var order in orderQuerywithCust)
				//{
				//	if (order.Customer != null)
				//	{
				//		Console.WriteLine($"{order.Customer.ContactName} of {order.Customer.City} paid {order.Freight} for shipping.");
				//	}

				////1.1 Query that lists all customers in either paris or london including id company name and all address fields
				//var customerQuery =
				//	from customer in db.Customers
				//	where customer.City == "Paris" || customer.City == "London"
				//	select customer;

				//foreach (var customer in customerQuery)
				//{
				//	Console.WriteLine($"{customer.CustomerId} - {customer.CompanyName} - {customer.Address} - {customer.City} - {customer.PostalCode} - {customer.Country}");
				//}

				////1.2
				//var ProductInBottles = from product in db.Products
				//					   where product.QuantityPerUnit.Contains("bottle")
				//					   select product;
				//foreach (var product in ProductInBottles)
				//{
				//	Console.WriteLine($"{product.ProductName} - {product.QuantityPerUnit}");
				//}
			}
		}
	}
}
