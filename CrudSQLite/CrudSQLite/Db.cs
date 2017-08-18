using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;

namespace CrudSQLite
{
	public class Db : IDisposable
	{
		private SQLiteConnection sqliteConnection;

		public Db()
		{
			var config = DependencyService.Get<IConfig>();
			sqliteConnection = new SQLiteConnection(Path.Combine(config.SQLiteDirectory, "data.db3"));
			sqliteConnection.CreateTable<Customer>();
		}

		public void InsertCustomer(Customer customer)
		{
			sqliteConnection.Insert(customer);
		}

		public void UpdateCustomer(Customer customer)
		{
			sqliteConnection.Update(customer);
		}

		public void DeleteCustomer(Customer customer)
		{
			sqliteConnection.Delete(customer);
		}

		public Customer GetCustomerById(Customer customer)
		{
			return sqliteConnection.Table<Customer>().FirstOrDefault(c => c.Id == customer.Id);
		}

		public List<Customer> GetAllCustomers()
		{
			return sqliteConnection.Table<Customer>().OrderBy(c => c.Name).ToList();
		}

		public void Dispose()
		{
			sqliteConnection.Close();
		}
	}
}
