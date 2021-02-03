using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDatabase
{
	public partial class Customer
	{
		public override string ToString()
		{
			return $"{CustomerId} - {ContactName} - {City}";
		}
	}
}
