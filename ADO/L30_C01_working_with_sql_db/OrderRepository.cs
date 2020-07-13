using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.Threading;
using Microsoft.Data.SqlClient;

namespace L30_C01_working_with_sql_db
{
	public class OrderRepository
	{
		private readonly string _connectionString;

		public OrderRepository(string connectionString)
		{
			_connectionString = connectionString;
		}

		public int Create(
			int customerId,
			float discount,
			Dictionary<int, int> lines)
		{
			using var connection = CreateConnection();
			using var transaction = connection.BeginTransaction();

			try
			{
				using var orderCommand = connection.CreateCommand();
				orderCommand.Transaction = transaction;
				orderCommand.CommandText = "sp_OrdersCreate";
				orderCommand.CommandType = CommandType.StoredProcedure;
				orderCommand.Parameters.AddWithValue("customerId", customerId);
				orderCommand.Parameters.AddWithValue("discount", discount);
				var id = orderCommand.Parameters.Add("id", SqlDbType.Int);
				id.Direction = ParameterDirection.Output;
				orderCommand.ExecuteNonQuery();

				var orderId = (int)id.Value;
				foreach (var (productId, count) in lines)
				{
					using var lineCommand = connection.CreateCommand();
					lineCommand.Transaction = transaction;
					lineCommand.CommandText =
						@"INSERT INTO [OrderLine]([OrderId], [ProductId], [Count]) 
					  VALUES (@orderId, @productId, @count)";
					lineCommand.CommandType = CommandType.Text;
					lineCommand.Parameters.AddWithValue("orderId", orderId);
					lineCommand.Parameters.AddWithValue("productId", productId);
					lineCommand.Parameters.AddWithValue("count", count);
					lineCommand.ExecuteNonQuery();
				}

				transaction.Commit();

				return orderId;
			}
			catch (SqlException)
			{
				transaction.Rollback();
				throw;
			}
		}
		public int GetCount()
		{
			using var connection = CreateConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT COUNT(*) FROM [Order]";
			command.CommandType = CommandType.Text;
			return (int)command.ExecuteScalar();
		}

		public Order GetById(string customer)
		{
			using var connection = CreateConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM [Order] WHERE Customer = @customer";
			command.CommandType = CommandType.Text;
			command.Parameters.AddWithValue("customer", customer);

			using var reader = command.ExecuteReader();
			var result = Read(reader).FirstOrDefault();
			if (result == null)
			{
				throw new ArgumentException($"Order with id {customer} is not found");
			}

			return result;
		}

		public List<Order> GetAll(int customer, int total)
		{
			using var connection = CreateConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM [Order] WHERE Customer = @customer";
			command.CommandType = CommandType.Text;
			command.Parameters.AddWithValue("customer", customer);
			command.CommandText = "SELECT * FROM [Order] WHERE Total = @total";
			command.CommandType = CommandType.Text;
			command.Parameters.AddWithValue("total", total);

			using var reader = command.ExecuteReader();
			return Read(reader).ToList();
		}

		private IEnumerable<Order> Read(SqlDataReader reader)
		{
			if (!reader.HasRows)
			{
				yield break;
			}

			var idIndex = reader.GetOrdinal("Id");
			var customerIndex = reader.GetOrdinal("Customer");
			var orderDateIndex = reader.GetOrdinal("OrderDate");
			var discountIndex = reader.GetOrdinal("Discount");
			var totalIndex = reader.GetOrdinal("Total");
			while (reader.Read())
			{
				yield return new Order(
					reader.GetInt32(idIndex),
					reader.GetString(customerIndex),
					reader.GetDateTimeOffset(orderDateIndex),
					reader.GetFloat(discountIndex),
					reader.GetInt32(totalIndex));
			}
		}

		private SqlConnection CreateConnection()
		{
			var connection = new SqlConnection(_connectionString);
			connection.Open();
			return connection;
		}
	}
}
