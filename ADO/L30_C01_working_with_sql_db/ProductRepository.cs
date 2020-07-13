using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace L30_C01_working_with_sql_db
{
	public class ProductRepository
	{
		private readonly string _connectionString;

		public ProductRepository(string connectionString)
		{
			_connectionString = connectionString;
		}

		public int GetCount()
		{
			using var connection = CreateConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT COUNT(*) FROM [Product]";
			command.CommandType = CommandType.Text;
			return (int) command.ExecuteScalar();
		}

		public Product GetById(int id)
		{
			using var connection = CreateConnection();
			using var command = connection.CreateCommand();
			// command.CommandText = $"SELECT * FROM [Product] WHERE Id = {id}";
			command.CommandText = "SELECT * FROM [Product] WHERE Id = @id";
			command.CommandType = CommandType.Text;
			command.Parameters.AddWithValue("id", id);

			using var reader = command.ExecuteReader();
			var result = Read(reader).FirstOrDefault();
			if (result == null)
			{
				throw new ArgumentException($"Product with id {id} is not found");
			}

			return result;
		}

		public List<Product> GetAll()
		{
			using var connection = CreateConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM [Product]";
			command.CommandType = CommandType.Text;

			using var reader = command.ExecuteReader();
			return Read(reader).ToList();
		}

		public int Create(string name, decimal price)
		{
			using var connection = CreateConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "sp_ProductsCreate";
			command.CommandType = CommandType.StoredProcedure;
			command.Parameters.AddWithValue("name", name);
			command.Parameters.AddWithValue("price", price);
			var id = command.Parameters.Add("id", SqlDbType.Int);
			id.Direction = ParameterDirection.Output;
			command.ExecuteNonQuery();

			return (int) id.Value;
		}

		private IEnumerable<Product> Read(SqlDataReader reader)
		{
			if (!reader.HasRows)
			{
				yield break;
			}

			var idIndex = reader.GetOrdinal("Id");
			var nameIndex = reader.GetOrdinal("Name");
			var priceIndex = reader.GetOrdinal("Price");

			while (reader.Read())
			{
				yield return new Product(
					reader.GetInt32(idIndex),
					reader.GetString(nameIndex),
					reader.GetDecimal(priceIndex));
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