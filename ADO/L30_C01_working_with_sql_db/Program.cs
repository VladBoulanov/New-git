using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using Microsoft.Data.SqlClient;

namespace L30_C01_working_with_sql_db
{
	internal class Program
	{
		private const string ConnectionString =
			"Server=tcp:shadow-art.database.windows.net,1433;" +
			"Initial Catalog=reminder; " +
			"Persist Security Info=False;" +
			"User ID=app_user@shadow-art;" +
			"Password=XCrzJjTRqX43uzaEpJNj;" +
			"Encrypt=True;";

		private static void Main(string[] args)
		{
			var orderRepository = new OrderRepository(ConnectionString);
			var orderId = orderRepository.Create(
				4,
				0.0f,
				new Dictionary<int, int>
				{
					[10] = 5,
					[26] = 4
				}
			);

			Console.WriteLine($"Created order id: {orderId}");
			Console.ReadLine();
		}
	}

	
}