using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(CrudSQLite.Droid.Config))]
namespace CrudSQLite.Droid
{
	public class Config : IConfig
	{
		public string SQLiteDirectory => Environment.GetFolderPath(Environment.SpecialFolder.Personal);
	}
}