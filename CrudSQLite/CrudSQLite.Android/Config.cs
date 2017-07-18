using System;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;
using Xamarin.Forms;

[assembly: Dependency(typeof(CrudSQLite.Droid.Config))]
namespace CrudSQLite.Droid
{
	public class Config : IConfig
	{
		private string sqliteDirectory;
		private ISQLitePlatform platform;

		public string SQLiteDirectory => sqliteDirectory ?? Environment.GetFolderPath(Environment.SpecialFolder.Personal);

		public ISQLitePlatform Platform => platform ?? new SQLitePlatformAndroid();
	}
}