namespace L30_C01_working_with_sql_db
{
	public class Product
	{
		public int Id { get; }
		public string Name { get; }
		public decimal Price { get; }

		public Product(int id, string name, decimal price)
		{
			Id = id;
			Name = name;
			Price = price;
		}

		public override string ToString() =>
			$"\"{Name}\" (Id: {Id}) with price {Price}";
	}
}