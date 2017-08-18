using SQLite;

namespace CrudSQLite
{
	public class Customer
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		[MaxLength(100)]
		public string Name { get; set; }
		[MaxLength(255)]
		public string Email { get; set; }
		public override string ToString()
		{
			return $"{Name} {Email}";
		}
	}
}
